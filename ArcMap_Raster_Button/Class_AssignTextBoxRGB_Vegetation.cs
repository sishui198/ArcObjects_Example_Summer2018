﻿// GISC 6387 - Workshop Project
// David Lindsey - dcl160230@utdallas.edu
//
// This code controls how the RGB combination textboxes will populate with Vegetation combobox selection.

namespace ArcMap_Raster_Button
{
    class Class_AssignTextBoxRGB_Vegetation
    {

        // Nullable integer variables for RGB.
        public static int? int_R;
        public static int? int_G;
        public static int? int_B;

        public void RGB_Assignments_Vegetation(GUI_AddRaster theGUI)
        {

            if (theGUI.combo_SensorType.SelectedItem.ToString() == "ASTER")
            {

                // RGB Band values
                int_R = 3;
                int_G = 2;
                int_B = 1;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "EO-1 ALI")
            {

                // RGB Band values
                int_R = 7;
                int_G = 5;
                int_B = 4;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "EO-1 Hyperion")
            {

                // RGB Band values
                int_R = 50;
                int_G = 29;
                int_B = 23;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "FormoSat-1")
            {

                // RGB Band values
                int_R = 6;
                int_G = 5;
                int_B = 4;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "FormoSat-2")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "FormoSat-5")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "GeoEye-1")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "IKONOS")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Landsat 1-5 MSS")
            {

                // RGB Band values
                int_R = 4;
                int_G = 2;
                int_B = 1;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Landsat 4-5 TM")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Landsat 7")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Landsat 8")
            {

                // RGB Band values
                int_R = 5;
                int_G = 4;
                int_B = 3;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "MODIS")
            {

                // RGB Band values
                int_R = 2;
                int_G = 1;
                int_B = 4;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "NAIP 3-Band")
            {

                // This RGB combination is not available for this sensor.
                int_R = null;
                int_G = null;
                int_B = null;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = null;
                theGUI.textBox_G.Text = null;
                theGUI.textBox_B.Text = null;

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "NAIP 4-Band")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "OrbView-3")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Pleiades-1")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "QuickBird")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "RapidEye")
            {

                // RGB Band values
                int_R = 5;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Sentinel-2")
            {

                // RGB Band values
                int_R = 8;
                int_G = 4;
                int_B = 3;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "Sentinel-3")
            {

                // RGB Band values
                int_R = 17;
                int_G = 8;
                int_B = 6;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "SPOT 1-3")
            {

                // RGB Band values
                int_R = 3;
                int_G = 2;
                int_B = 1;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "SPOT 4-5")
            {

                // RGB Band values
                int_R = 3;
                int_G = 2;
                int_B = 1;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "SPOT 6-7")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "WorldView-2")
            {

                // RGB Band values
                int_R = 7;
                int_G = 5;
                int_B = 3;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "WorldView-3")
            {

                // RGB Band values
                int_R = 7;
                int_G = 5;
                int_B = 3;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

            else if (theGUI.combo_SensorType.SelectedItem.ToString() == "WorldView-4")
            {

                // RGB Band values
                int_R = 4;
                int_G = 3;
                int_B = 2;

                // Set RGB band values to textboxes.
                theGUI.textBox_R.Text = int_R.ToString();
                theGUI.textBox_G.Text = int_G.ToString();
                theGUI.textBox_B.Text = int_B.ToString();

            }

        }

    }

}