using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BikeRentalScript : MonoBehaviour
{
    public TextMeshProUGUI rentalOptionsText;

    // Arrays for bike models
    private string[] mountainBikes = { "Beginner Mountain Bike", "Intermediate Mountain Bike", "Advanced Mountain Bike" };
    private string[] roadBikes = { "Entry Road Bike", "Performance Road Bike", "Racing Road Bike" };

    // Lists for helmets and bike accessories
    private List<string> helmets = new List<string> { "Small Helmet", "Medium Helmet", "Large Helmet" };
    private List<string> accessories = new List<string> { "Water Bottle", "Bike Lock", "Phone Mount" };

    // Property for customer status (VIP or regular)
    private bool isVIP;
    public bool IsVIP
    {
        get { return isVIP; }
        set { isVIP = value; }
    }

    // Function to display the rental options menu
    public void ShowRentalMenu()
    {
        string menuText = "Welcome to our Bike Rental Menu!\n";

        menuText += "\n--- Mountain Bike Options ---\n";
        menuText += GetOptionsText(mountainBikes);

        menuText += "\n--- Road Bike Options ---\n";
        menuText += GetOptionsText(roadBikes);

        menuText += "\n--- Helmet Options ---\n";
        menuText += GetOptionsText(helmets);

        menuText += "\n--- Accessories Options ---\n";
        menuText += GetOptionsText(accessories);

        // VIP status offers additional discount message
        if (isVIP)
        {
            menuText += "\nAs a VIP customer, you receive a 10% discount on all rentals!";
        }
        else
        {
            menuText += "\nBecome a VIP member for discounts!";
        }

        // Update the TMP text with the rental menu
        rentalOptionsText.text = menuText;
    }

    // Function to generate options text for arrays
    private string GetOptionsText(string[] options)
    {
        string result = "";
        for (int i = 0; i < options.Length; i++)
        {
            result += (i + 1) + ". " + options[i] + "\n";
        }
        return result;
    }

    // Function to generate options text for lists
    private string GetOptionsText(List<string> options)
    {
        string result = "";
        for (int i = 0; i < options.Count; i++)
        {
            result += (i + 1) + ". " + options[i] + "\n";
        }
        return result;
    }

    private void Start()
    {
        // Set VIP status
        IsVIP = false;

        ShowRentalMenu();
    }
}
