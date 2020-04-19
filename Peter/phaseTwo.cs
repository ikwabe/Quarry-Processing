using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace Peter
{
    public partial class phaseTwo : UserControl
    {
        public phaseTwo()
        {
            InitializeComponent();
        }

        //variables for answers
        double charge_length = 0.00;
        double blast_tonnes = 0.00;
        double volume_of_blast_hole = 0.00;
        double mass_of_exprosive_per_hole = 0.00;
        double vertical_length_of_angle_holes = 0.00;
        //  double spacing = 0.00;
        //double burden = 0.00;
        double volume_of_material_blasted = 0.00;
        double total_volume_of_material_blasted = 0.00;
        //double number_of_holes = 0;
        double amount_of_explosive = 0.00;
        double cost_of_drilling = 0.00;
        double cost_of_blasting = 0.00;
        double hole_length = 0.00;
        double area_available = 0.00;
        double drilling_and_blasting_area = 0.00;
        int repeatitive_op_number = 0;
        double vertical_energy_distribution = 0.00;
        double loading_density = 0.00;
        double charge_energy = 0.00;
        double energy_factor = 0.00;
        double energy_different = 0.00;
        double drillingRequired = 0.00;
        double drillingCost = 0.00;
        double totalExploWeight = 0.00;
        double ExplosiveCOst = 0.00;
        double InitiationCost = 0.00;
        double laborCost = 0.00;
        double MisceleniousCost = 0.00;
        public static double TotalCost = 0.00;
        double CostDifference = 0.00;
        public static double TotalUnitCost = 0.00;
        double TotalUnitDifference = 0.00;
        double drillingCOstPercent = 0.00;
        double ExposiveCostPercent = 0.00;
        double InitiationCostPerent = 0.00;
        double LaborCostPercent = 0.00;
        int numberOfHoles = 0;


        //new Added

        double powderFactor = 0.00;
        double powderFactor2 = 0.00;

        double successPercentageProduction = 0.00;
        double burdenStiffnessRatio = 0.00;
        double particleSize = 0.00;
        double diameterOfHole = 0.00;
        //end

        int anfoBox = 0;

        int boosterPiece = 0;

       

        //function for calculating anfoBox and Explogel
        void Calculate()
        {
            if (numberOfHoles == 0 || hole_length == 0.00)
            {
                DrillingRequiredLabel.Text = "Loading...";
            }
            else
            {
                drillingRequired = Math.Round(numberOfHoles * hole_length, 2);
                DrillingRequiredLabel.Text = drillingRequired.ToString() + "m";

            }

            if (string.IsNullOrWhiteSpace(DrillingCostperMetreTxt.Text)  || drillingRequired == 0.00)
            {
                DrillingCostLabel.Text = "Loading...";
            }
            else
            {
                drillingCost = Math.Round( drillingRequired * float.Parse(DrillingCostperMetreTxt.Text),2);
                DrillingCostLabel.Text = string.Format("{0:n}", drillingCost) + "$";
            }

            if (mass_of_exprosive_per_hole == 0.00 || numberOfHoles == 0)
            {
                TotalExploWeightLabel.Text = "Loading...";
            }
            else
            {
                totalExploWeight = Math.Round(mass_of_exprosive_per_hole * numberOfHoles, 2);
                TotalExploWeightLabel.Text = totalExploWeight.ToString() + "Kg";
            }

            if(totalExploWeight == 0.00 || string.IsNullOrWhiteSpace(ExplosiveCostperKgTxt.Text))
            {
                explosiveCostLabel.Text = "Loading...";

            }
            else
            {
                ExplosiveCOst = Math.Round(totalExploWeight * float.Parse(ExplosiveCostperKgTxt.Text));
                explosiveCostLabel.Text = string.Format("{0:n}", ExplosiveCOst) + "$";
            }

            if(string.IsNullOrWhiteSpace(InitialCostperholeTxt.Text) || numberOfHoles == 0)
            {
                InitialCostLabel.Text = "Loading...";

            }
            else
            {
                InitiationCost = Math.Round(float.Parse(InitialCostperholeTxt.Text) * numberOfHoles, 2);
                InitialCostLabel.Text = string.Format("{0:n}", InitiationCost) + "$";

            }

            if (string.IsNullOrWhiteSpace(LaborCostperholeTxt.Text) || numberOfHoles == 0)
            {
                laborCostLabel.Text = "Loading...";

            }
            else
            {
                laborCost = Math.Round(float.Parse(LaborCostperholeTxt.Text) * numberOfHoles, 2);
                laborCostLabel.Text = string.Format("{0:n}", laborCost) + "$";

            }

            if (string.IsNullOrWhiteSpace(MiscellaneousperholeTxt.Text) || numberOfHoles == 0)
            {
                MiscCostLabel.Text = "Loading...";

            }
            else
            {
                MisceleniousCost = Math.Round(float.Parse(MiscellaneousperholeTxt.Text) * numberOfHoles, 2);
                MiscCostLabel.Text = string.Format("{0:n}", MisceleniousCost) + "$";

            }

            if(drillingCost == 0.00 && MisceleniousCost == 0.00 && laborCost ==.00 && InitiationCost == 0.00 && ExplosiveCOst == 0.00)
            {
                TotalCostLabel.Text = "Loading...";
            }
            else
            {
                TotalCost = drillingCost + MisceleniousCost + laborCost + InitiationCost + ExplosiveCOst;
                TotalCostLabel.Text = string.Format("{0:n}", TotalCost) + "$";
            }

            if(string.IsNullOrWhiteSpace(ProductionUnitsRequiredTxt.Text) || TotalCost == 0.00)
            {
                TotalUnitCostLabel.Text = "Loading...";
            }
            else
            {
                TotalUnitCost = Math.Round(TotalCost / float.Parse(ProductionUnitsRequiredTxt.Text), 2);
                TotalUnitCostLabel.Text = string.Format("{0:n}", TotalUnitCost) + "$";
            }

            if(drillingCost == 0.00 || TotalCost == 0.00)
            {
                DrillingCostPercentLabel.Text = "Loading...";

            }
            else
            {
                drillingCOstPercent = Math.Round((drillingCost / TotalCost) * 100, 2);
                DrillingCostPercentLabel.Text = drillingCOstPercent.ToString() + "%";
            }

            if (ExplosiveCOst == 0.00 || TotalCost == 0.00)
            {
                ExplosiveCostPercentLabel.Text = "Loading...";

            }
            else
            {
                ExposiveCostPercent = Math.Round((ExplosiveCOst / TotalCost) * 100, 2);
                ExplosiveCostPercentLabel.Text = ExposiveCostPercent.ToString() + "%";
            }

            if (InitiationCost == 0.00 || TotalCost == 0.00)
            {
                InitialCostPercentLabel.Text = "Loading...";

            }
            else
            {
                InitiationCostPerent = Math.Round((InitiationCost / TotalCost) * 100, 2);
                InitialCostPercentLabel.Text = InitiationCostPerent.ToString() + "%";
            }

            if (laborCost == 0.00 || TotalCost == 0.00)
            {
                LaborCostPercentLabel.Text = "Loading...";

            }
            else
            {
                LaborCostPercent = Math.Round((laborCost / TotalCost) * 100, 2);
                LaborCostPercentLabel.Text = LaborCostPercent.ToString() + "%";
            }

            if(phaseOne.TotalCost == 0.00 || TotalCost == 0.00)
            {
                CostDifferenceLabel.Text = "Loading...";
            }
            else
            {
                CostDifference = TotalCost - phaseOne.TotalCost;
                CostDifferenceLabel.Text = string.Format("{0:n}", CostDifference) + "$";
            }

            if (phaseOne.TotalUnitCost == 0.00 || TotalUnitCost == 0.00)
            {
                DifferenceLabel.Text = "Loading...";
            }
            else
            {
                TotalUnitDifference = TotalUnitCost - phaseOne.TotalUnitCost;
                DifferenceLabel.Text = string.Format("{0:n}", TotalUnitDifference) + "$";
            }
        }

        private void Diameter_of_the_hole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool timerSwitch = false;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(timerSwitch == true)
            {

            try
            {
                //convention to mm
                diameterOfHole = double.Parse(Diameter_of_the_hole.Text) / 1000;

                if (diameterOfHole != 0.00)
                {

                    //updates
                    hole_length = float.Parse(benchHEightTxt.Text) + float.Parse(subdrilTxt.Text);
                    hole_length_label.Text = hole_length.ToString() + "m";

                    burdenStiffnessRatio = Math.Round(float.Parse(benchHEightTxt.Text) / float.Parse(burdenTxt.Text), 2);

                    vertical_energy_distribution = Math.Round((((float.Parse(benchHEightTxt.Text) - float.Parse(steamingTxt.Text)) / float.Parse(benchHEightTxt.Text)) * 100), 2);
                    energyDistLabel.Text = vertical_energy_distribution.ToString() + "%";

                    charge_length = Math.Round(hole_length - float.Parse(steamingTxt.Text), 2);
                    charge_lengh_label.Text = charge_length.ToString() + "m";

                    volume_of_blast_hole = Math.Round(3.14 * (Math.Pow((diameterOfHole), 2) / 4) * charge_length, 4);
                    volume_of_blast_hole_label.Text = volume_of_blast_hole.ToString() + "m3";

                    if (burdenStiffnessRatio > 2 && burdenStiffnessRatio < 3.5)
                    {
                        burdenStiffnessRatioLabel.Text = burdenStiffnessRatio.ToString() + " Good Fragmentation";
                    }
                    else if (burdenStiffnessRatio > 3.5)
                    {
                        burdenStiffnessRatioLabel.Text = burdenStiffnessRatio.ToString() + " Very Good Fragmentation";
                    }
                    else
                    {
                        burdenStiffnessRatioLabel.Text = "The Burden Stiffness is below 2";
                    }

                    if (string.IsNullOrWhiteSpace(explosiveEnergTxt.Text))
                    {
                        loadingDensityLabel.Text = "Loading...";
                    }
                    else
                    {
                        loading_density = Math.Round(0.000785 * float.Parse(Explosive_density.Text) * Math.Pow(diameterOfHole, 2), 5);
                        loadingDensityLabel.Text = loading_density.ToString() + "Kg/m";
                    }

                }
                else
                {
                    energyDistLabel.Text = "Loading...";
                }

            }
            catch
            {

            }


            if (volume_of_material_blasted == 0.00 || Density_of_the_rock.Text == "" || plannedProductionTxt.Text == "")
            {
                blast_tonnes_label.Text = "Loading...";
                successPercentageProductionLabel.Text = "Loading...";
                achievedProductionLabel.Text = "Loading...";
                totalBlastedTonnesLabel.Text = "Loading...";
            }
            else
            {
                try
                {
                    blast_tonnes = Math.Round(volume_of_material_blasted * (double.Parse(Density_of_the_rock.Text) / 1000), 3);

                    blast_tonnes_label.Text = blast_tonnes.ToString() + " tonnes";

                    totalBlastedTonnesLabel.Text = (blast_tonnes * numberOfHoles).ToString() + " tonnes";

                    achievedProductionLabel.Text = (blast_tonnes * numberOfHoles).ToString() + " tonnes";

                    successPercentageProduction = Math.Round(((blast_tonnes * numberOfHoles) / (double.Parse(plannedProductionTxt.Text))) * 100, 2);

                    successPercentageProductionLabel.Text = successPercentageProduction.ToString() + "%";
                }
                catch
                {

                }
            }

            if (volume_of_material_blasted == 0.00 || powderFactor == 0.00)
            {
                amount_of_explosive_label.Text = "Loading...";
            }
            else
            {
                try
                {

                    amount_of_explosive = Math.Round(powderFactor * total_volume_of_material_blasted, 3);
                    amount_of_explosive_label.Text = amount_of_explosive.ToString() + "kg";
                }
                catch
                {

                }
            }



            if (string.IsNullOrWhiteSpace(benchHEightTxt.Text)  || string.IsNullOrWhiteSpace(burdenTxt.Text) || string.IsNullOrWhiteSpace(spacingTxt.Text))
            {

                boosterPiece = 0;
                boosterPieceLabel.Text = "Loading...";
                totalVolumeOfMaterialBlasted.Text = "Loading...";
                volumeOfMaterialPerOneHoleLabel.Text = "Loading...";
            }
            else
            {
                try
                {
                    volume_of_material_blasted = Math.Round((float.Parse(burdenTxt.Text) * float.Parse(spacingTxt.Text) * float.Parse(benchHEightTxt.Text)), 2);
                    total_volume_of_material_blasted = Math.Round(drilling_and_blasting_area * float.Parse(benchHEightTxt.Text), 2);

                    numberOfHoles = (int)(total_volume_of_material_blasted / volume_of_material_blasted);

                    boosterPiece = numberOfHoles;
                    boosterPieceLabel.Text = boosterPiece + "";
                    totalVolumeOfMaterialBlasted.Text = total_volume_of_material_blasted + "m3";
                    volumeOfMaterialPerOneHoleLabel.Text = volume_of_material_blasted + "m3";
                    numberOfHolesLabel.Text = numberOfHoles.ToString();
                }
                catch
                {

                }
            }

            if (Explosive_density.Text == "" || volume_of_blast_hole == 0.00)
            {
                mass_explosive_label.Text = "Loading...";
                charge.Text = "Loading...";
            }
            else
            {
                try
                {

                    mass_of_exprosive_per_hole = Math.Round(double.Parse(Explosive_density.Text) * volume_of_blast_hole, 1);
                    mass_explosive_label.Text = mass_of_exprosive_per_hole.ToString() + "kg";

                    charge_energy = Math.Round(mass_of_exprosive_per_hole * float.Parse(explosiveEnergTxt.Text), 2);
                    charge.Text = charge_energy.ToString() + "Kj/hole";


                }
                catch
                {

                }
            }

                if (charge_energy == 0.00 || blast_tonnes == 0.00)
                {
                    energyFactorLabel.Text = "Loading...";
                }
                else
                {
                    energy_factor = Math.Round(charge_energy / blast_tonnes, 2);
                    energyFactorLabel.Text = energy_factor.ToString() + "Kj/tonne";
                }

                //if for Powder Factor

                if (mass_of_exprosive_per_hole == 0.00 || volume_of_material_blasted == 0.00)
            {
                powderFactorLabel.Text = "Loading...";
                powderFactor2Label.Text = "Loading...";
            }
            else
            {
                powderFactor = Math.Round((mass_of_exprosive_per_hole / volume_of_material_blasted), 2);

                powderFactor2 = Math.Round((mass_of_exprosive_per_hole / blast_tonnes), 2);

                powderFactor2Label.Text = powderFactor2.ToString() + "kg/tonnes";

                if (powderFactor > 0.7 && powderFactor < 0.9)
                {
                    powderFactorLabel.Text = powderFactor.ToString() + "kg/m3 Hard Rock";
                   
                }

                if (powderFactor > 0.4 && powderFactor < 0.7)
                {
                    powderFactorLabel.Text = powderFactor.ToString() + "kg/m3 Medium Rock";
                    
                }

                if (powderFactor > 0.25 && powderFactor < 0.4)
                {
                    powderFactorLabel.Text = powderFactor.ToString() + "kg/m3 Soft Rock";
                    
                }

                if (powderFactor > 0.15 && powderFactor < 0.25)
                {
                    powderFactorLabel.Text = powderFactor.ToString() + "kg/m3 Very Soft Rock";
                    
                }

            }

            if (hole_length == 0.00 || string.IsNullOrWhiteSpace(AngleSubtendedVerticallyTxt.Text))
            {
                vertical_length_label.Text = "Loading...";
            }
            else
            {
                try
                {
                    vertical_length_of_angle_holes = Math.Round(Math.Cos(double.Parse(AngleSubtendedVerticallyTxt.Text)) * hole_length, 1);
                    vertical_length_label.Text = vertical_length_of_angle_holes.ToString() + "m";

                }
                catch
                {

                }
            }

           

            try
            {
                //the function to check the values of anfobox used and explogel to be used
                Calculate();
            }
            catch
            {

            }
           
            if (length_of_area_available.Text == "" || width_of_the_area_available.Text == "")
            {
                areaAvailableLabel.Text = "Loading...";
                area_available = 0.00;
            }
            else
            {
                area_available = double.Parse(length_of_area_available.Text) * double.Parse(width_of_the_area_available.Text);
                areaAvailableLabel.Text = area_available + " m2";
            }

            if (drilling_and_blasing_area_width.Text == "" || drilling_and_blasting_area_length.Text == "")
            {
                drillingAndBlastingAreaLabel.Text = "Loading...";
                drilling_and_blasting_area = 0.00;
            }
            else
            {
                drilling_and_blasting_area = double.Parse(drilling_and_blasting_area_length.Text) * double.Parse(drilling_and_blasing_area_width.Text);
                drillingAndBlastingAreaLabel.Text = drilling_and_blasting_area + " m2";

            }

            if (drilling_and_blasting_area != 0.00 && area_available != 0.00)
            {
                repeatitive_op_number = (int)(area_available / drilling_and_blasting_area);
                repetitiveOperationNumberLable.Text = repeatitive_op_number + "";
            }

            else
            {

                repetitiveOperationNumberLable.Text = "Loading...";
            }

            if (Diameter_of_the_hole.Text != "")
            {
                //Volume_of_materials_blasted.Enabled = true;
                //volumeOfmaterialLabel.Text = "";
            }
            else
            {
                volume_of_blast_hole_label.Text = "Loading...";

                hole_length_label.Text = "Loading...";
                charge_lengh_label.Text = "Loading...";

                burdenStiffnessRatioLabel.Text = "Loading...";

               
            }


            //if for Particle Size
            if (powderFactor == 0.00 || mass_of_exprosive_per_hole == 0.00 || string.IsNullOrWhiteSpace(rockFactorTxt.Text) || string.IsNullOrWhiteSpace(RWStxt.Text))
            {
                particleSizeLabel.Text = "Loading...";
            }
            else
            {
                particleSize = Math.Round(float.Parse(rockFactorTxt.Text) * Math.Pow(powderFactor, -0.8) * Math.Pow(mass_of_exprosive_per_hole, (1 / 6)) * Math.Pow((115 / float.Parse(RWStxt.Text)), (19 / 20)), 2);
                particleSizeLabel.Text = particleSize.ToString() + "cm";

                if (string.IsNullOrWhiteSpace(bounderTxt.Text) || string.IsNullOrWhiteSpace(DfromTxt.Text) || string.IsNullOrWhiteSpace(DtoTxt.Text) || string.IsNullOrWhiteSpace(FinesTxt.Text))
                {

                }
                else
                {
                    if (particleSize > float.Parse(bounderTxt.Text))
                        particleSizeLabel.Text = particleSize.ToString() + "cm  Boulder";
                    if (particleSize > float.Parse(DfromTxt.Text) && particleSize < float.Parse(DtoTxt.Text))
                        particleSizeLabel.Text = particleSize.ToString() + "cm  Desired Particle Size";
                    if (particleSize < float.Parse(FinesTxt.Text))
                        particleSizeLabel.Text = particleSize.ToString() + "cm  Fines";

                }


            }

            //for difference
            if (phaseOne.energy_factor == 0.00 || energy_factor == 0.00)
            {
                energyDifferenceLabel.Text = "Loading...";
            }
            else
            {
                energy_different = Math.Round((energy_factor - phaseOne.energy_factor) / phaseOne.energy_factor, 2);
                energyDifferenceLabel.Text = energy_different.ToString();
            }
        }
    }


        //statement to check if the file is saved
        bool check = false;
        private void SaveExeclFile()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            int col = 2;

            if (check == false)
            {
                using (SaveFileDialog save = new SaveFileDialog() { Filter = "Excel Workbook|.xlsx" })
                {
                    save.InitialDirectory = @"C:/Users/" + Environment.UserName + "/Documents";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        //giving the column names

                        ws.Cells[1, 1] = "INPUT PARAMETERS ";
                        ws.Cells[2, 1] = "Diameter of the hole (D) in mm";
                        ws.Cells[3, 1] = "Length of the Area  in m";
                        ws.Cells[4, 1] = "Width of the Area in m";
                        ws.Cells[5, 1] = "Drilling and Blasting length in m";
                        ws.Cells[6, 1] = "Drilling and Blasting width in m";
                        ws.Cells[7, 1] = "Number of holes";
                        ws.Cells[8, 1] = "Density of the rock (ρ) in kg/ m3";
                        ws.Cells[9, 1] = "Explosive density, De in kg/ m3";
                        ws.Cells[10, 1] = "Planned Production";
                        ws.Cells[11, 1] = "Explosive Energy (J/g)";
                        ws.Cells[12, 1] = "Angle Subtended Vertically by inclined hole";
                        ws.Cells[13, 1] = "Burden";
                        ws.Cells[14, 1] = "Spacing";
                        ws.Cells[15, 1] = "Steaming Length";
                        ws.Cells[16, 1] = "Sub-drill";
                        ws.Cells[17, 1] = "Bench Height";
                        ws.Cells[18, 1] = "Rock Factor";
                        ws.Cells[19, 1] = "RWS";
                        ws.Cells[20, 1] = "Bounder For Particle Size(>)";
                        ws.Cells[21, 1] = "Desired particle size from";
                        ws.Cells[22, 1] = "Desired particle size to";
                        ws.Cells[23, 1] = "Fines for Particle size (<)";
                        ws.Cells[24, 1] = "Production Units Required";
                        ws.Cells[25, 1] = "Explosive Cost per Kg";
                        ws.Cells[26, 1] = "Initial Cost per hole";
                        ws.Cells[27, 1] = "Drilling Cost per Meter";
                        ws.Cells[28, 1] = "Labor Cost per hole";
                        ws.Cells[29, 1] = "Miscellaneous per hole";
                        ws.Cells[30, 1] = "";
                        ws.Cells[31, 1] = "";
                        ws.Cells[32, 1] = "OUTPUT RESULTS";
                        ws.Cells[33, 1] = "";
                        ws.Cells[34, 1] = "Drilling Results".ToUpper();
                        ws.Cells[35, 1] = "Hole length";
                        ws.Cells[36, 1] = "Area Available";
                        ws.Cells[37, 1] = "Drilling and Blasting Area";
                        ws.Cells[38, 1] = "Vertical length of angled holes";
                        ws.Cells[39, 1] = "Burden Stiffness ratio";
                        ws.Cells[40, 1] = "";
                        ws.Cells[41, 1] = "Blast Results".ToUpper();
                        ws.Cells[42, 1] = "Charge length";
                        ws.Cells[43, 1] = "Volume of blast hole";
                        ws.Cells[44, 1] = "Amount of explosives to be  used";
                        ws.Cells[45, 1] = "Mass of explosive per hole";
                        ws.Cells[46, 1] = "Booster/Explogel piece(s) number used";
                        ws.Cells[47, 1] = "Blast Tonnes @1 hole";
                        ws.Cells[48, 1] = "Total Blast Tonnes";
                        ws.Cells[49, 1] = "Repetitive Operation Number";
                        ws.Cells[50, 1] = "Achieved Production";
                        ws.Cells[51, 1] = "Success Percentage Production";
                        ws.Cells[52, 1] = "Volume of material to be blasted @1 hole";
                        ws.Cells[53, 1] = "Total Volume of material to be blasted";
                        ws.Cells[54, 1] = "Powder Factor";
                        ws.Cells[55, 1] = "Powder Factor";
                        ws.Cells[56, 1] = "Vertical Energy Distribution";
                        ws.Cells[57, 1] = "Loading Density";
                        ws.Cells[58, 1] = "Charge Energy";
                        ws.Cells[59, 1] = "Energy Factor";
                        ws.Cells[60, 1] = "Energy Difference";
                        ws.Cells[61, 1] = "Particle Size";
                        ws.Cells[62, 1] = "";
                        ws.Cells[63, 1] = "Cost Result".ToUpper();
                        ws.Cells[64, 1] = "Total Drilling Required";
                        ws.Cells[65, 1] = "Drilling Cost";
                        ws.Cells[66, 1] = "Total Explo. Weight";
                        ws.Cells[67, 1] = "Explosive Cost";
                        ws.Cells[68, 1] = "Initiation Cost";
                        ws.Cells[69, 1] = "Labor Cost";
                        ws.Cells[70, 1] = "Misc. Cost";
                        ws.Cells[71, 1] = "Total Cost";
                        ws.Cells[72, 1] = "Cost Difference";
                        ws.Cells[73, 1] = "Total Unit Cost";
                        ws.Cells[74, 1] = "Difference";
                        ws.Cells[75, 1] = "Drilling Cost %";
                        ws.Cells[76, 1] = "Explosive Cost %";
                        ws.Cells[77, 1] = "Initation Cost %";
                        ws.Cells[78, 1] = "Labor Cost %";



                        //feeding the data
                        ws.Cells[1, col] = "";
                        ws.Cells[2, col] = Diameter_of_the_hole.Text;
                        ws.Cells[3, col] = length_of_area_available.Text;
                        ws.Cells[4, col] = width_of_the_area_available.Text;
                        ws.Cells[5, col] = drilling_and_blasting_area_length.Text;
                        ws.Cells[6, col] = drilling_and_blasing_area_width.Text;
                        ws.Cells[7, col] = numberOfHoles;
                        ws.Cells[8, col] = Density_of_the_rock.Text;
                        ws.Cells[9, col] = Explosive_density.Text;
                        ws.Cells[10, col] = plannedProductionTxt.Text;
                        ws.Cells[11, col] = explosiveEnergTxt.Text;
                        ws.Cells[12, col] = AngleSubtendedVerticallyTxt.Text;
                        ws.Cells[13, col] = burdenTxt.Text;
                        ws.Cells[14, col] = spacingTxt.Text;
                        ws.Cells[15, col] = steamingTxt.Text;
                        ws.Cells[16, col] = subdrilTxt.Text;
                        ws.Cells[17, col] = benchHEightTxt.Text;
                        ws.Cells[18, col] = rockFactorTxt.Text;
                        ws.Cells[19, col] = RWStxt.Text;
                        ws.Cells[20, col] = bounderTxt.Text;
                        ws.Cells[21, col] = DfromTxt.Text;
                        ws.Cells[22, col] = DtoTxt.Text;
                        ws.Cells[23, col] = FinesTxt.Text;
                        ws.Cells[24, col] = ProductionUnitsRequiredTxt.Text;
                        ws.Cells[25, col] = ExplosiveCostperKgTxt.Text;
                        ws.Cells[26, col] = InitialCostperholeTxt.Text;
                        ws.Cells[27, col] = DrillingCostperMetreTxt.Text;
                        ws.Cells[28, col] = LaborCostperholeTxt.Text;
                        ws.Cells[29, col] = MiscellaneousperholeTxt.Text;
                        ws.Cells[30, col] = "";
                        ws.Cells[31, col] = "";
                        ws.Cells[32, col] = "";
                        ws.Cells[33, col] = "";
                        ws.Cells[34, col] = "";
                        ws.Cells[35, col] = hole_length;
                        ws.Cells[36, col] = areaAvailableLabel.Text;
                        ws.Cells[37, col] = drillingAndBlastingAreaLabel.Text;
                        ws.Cells[38, col] = vertical_length_label.Text;
                        ws.Cells[39, col] = burdenStiffnessRatioLabel.Text;
                        ws.Cells[40, col] = "";
                        ws.Cells[41, col] = "";
                        ws.Cells[42, col] = charge_lengh_label.Text;
                        ws.Cells[43, col] = volume_of_blast_hole_label.Text;
                        ws.Cells[44, col] = amount_of_explosive_label.Text;
                        ws.Cells[45, col] = mass_explosive_label.Text;
                        ws.Cells[46, col] = boosterPieceLabel.Text;
                        ws.Cells[47, col] = blast_tonnes_label.Text;
                        ws.Cells[48, col] = totalBlastedTonnesLabel.Text;
                        ws.Cells[49, col] = repetitiveOperationNumberLable.Text;
                        ws.Cells[50, col] = achievedProductionLabel.Text;
                        ws.Cells[51, col] = successPercentageProductionLabel.Text;
                        ws.Cells[52, col] = volumeOfMaterialPerOneHoleLabel.Text;
                        ws.Cells[53, col] = totalVolumeOfMaterialBlasted.Text;
                        ws.Cells[54, col] = powderFactorLabel.Text;
                        ws.Cells[55, col] = powderFactor2Label.Text;
                        ws.Cells[56, col] = energyDistLabel.Text;
                        ws.Cells[57, col] = loadingDensityLabel.Text;
                        ws.Cells[58, col] = charge.Text;
                        ws.Cells[59, col] = energyFactorLabel.Text;
                        ws.Cells[60, col] = energyDifferenceLabel.Text;
                        ws.Cells[61, col] = particleSizeLabel.Text;
                        ws.Cells[62, col] = "";
                        ws.Cells[63, col] = "Cost Result".ToUpper();
                        ws.Cells[64, col] = DrillingRequiredLabel.Text;
                        ws.Cells[65, col] = DrillingCostLabel.Text;
                        ws.Cells[66, col] = TotalExploWeightLabel.Text;
                        ws.Cells[67, col] = explosiveCostLabel.Text;
                        ws.Cells[68, col] = InitialCostLabel.Text;
                        ws.Cells[69, col] = laborCostLabel.Text;
                        ws.Cells[70, col] = MiscCostLabel.Text;
                        ws.Cells[71, col] = TotalCostLabel.Text;
                        ws.Cells[72, col] = CostDifferenceLabel.Text;
                        ws.Cells[73, col] = TotalUnitCostLabel.Text;
                        ws.Cells[74, col] = DifferenceLabel.Text;
                        ws.Cells[75, col] = DrillingCostPercentLabel.Text;
                        ws.Cells[76, col] = ExplosiveCostPercentLabel.Text;
                        ws.Cells[77, col] = InitialCostPercentLabel.Text;
                        ws.Cells[78, col] = LaborCostPercentLabel.Text;





                        ws.SaveAs(save.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        excel.Quit();
                        check = true;
                        col++;
                    }
                }
            }
            else
            {

                //feeding the data
                ws.Cells[1, col] = "";
                ws.Cells[2, col] = Diameter_of_the_hole.Text;
                ws.Cells[3, col] = length_of_area_available.Text;
                ws.Cells[4, col] = width_of_the_area_available.Text;
                ws.Cells[5, col] = drilling_and_blasting_area_length.Text;
                ws.Cells[6, col] = drilling_and_blasing_area_width.Text;
                ws.Cells[7, col] = numberOfHoles;
                ws.Cells[8, col] = Density_of_the_rock.Text;
                ws.Cells[9, col] = Explosive_density.Text;
                ws.Cells[10, col] = plannedProductionTxt.Text;
                ws.Cells[11, col] = explosiveEnergTxt.Text;
                ws.Cells[12, col] = AngleSubtendedVerticallyTxt.Text;
                ws.Cells[13, col] = burdenTxt.Text;
                ws.Cells[14, col] = spacingTxt.Text;
                ws.Cells[15, col] = steamingTxt.Text;
                ws.Cells[16, col] = subdrilTxt.Text;
                ws.Cells[17, col] = benchHEightTxt.Text;
                ws.Cells[18, col] = rockFactorTxt.Text;
                ws.Cells[19, col] = RWStxt.Text;
                ws.Cells[20, col] = bounderTxt.Text;
                ws.Cells[21, col] = DfromTxt.Text;
                ws.Cells[22, col] = DtoTxt.Text;
                ws.Cells[23, col] = FinesTxt.Text;
                ws.Cells[24, col] = ProductionUnitsRequiredTxt.Text;
                ws.Cells[25, col] = ExplosiveCostperKgTxt.Text;
                ws.Cells[26, col] = InitialCostperholeTxt.Text;
                ws.Cells[27, col] = DrillingCostperMetreTxt.Text;
                ws.Cells[28, col] = LaborCostperholeTxt.Text;
                ws.Cells[29, col] = MiscellaneousperholeTxt.Text;
                ws.Cells[30, col] = "";
                ws.Cells[31, col] = "";
                ws.Cells[32, col] = hole_length;
                ws.Cells[33, col] = areaAvailableLabel.Text;
                ws.Cells[34, col] = drillingAndBlastingAreaLabel.Text;
                ws.Cells[35, col] = vertical_length_label.Text;
                ws.Cells[36, col] = burdenStiffnessRatioLabel.Text;
                ws.Cells[37, col] = "";
                ws.Cells[38, col] = charge_lengh_label.Text;
                ws.Cells[39, col] = volume_of_blast_hole_label.Text;
                ws.Cells[40, col] = amount_of_explosive_label.Text;
                ws.Cells[41, col] = mass_explosive_label.Text;
                ws.Cells[42, col] = boosterPieceLabel.Text;
                ws.Cells[43, col] = blast_tonnes_label.Text;
                ws.Cells[44, col] = totalBlastedTonnesLabel.Text;
                ws.Cells[45, col] = repetitiveOperationNumberLable.Text;
                ws.Cells[46, col] = achievedProductionLabel.Text;
                ws.Cells[47, col] = successPercentageProductionLabel.Text;
                ws.Cells[48, col] = volumeOfMaterialPerOneHoleLabel.Text;
                ws.Cells[49, col] = totalVolumeOfMaterialBlasted.Text;
                ws.Cells[50, col] = powderFactorLabel.Text;
                ws.Cells[51, col] = powderFactor2Label.Text;
                ws.Cells[52, col] = energyDistLabel.Text;
                ws.Cells[53, col] = loadingDensityLabel.Text;
                ws.Cells[54, col] = charge.Text;
                ws.Cells[55, col] = energyFactorLabel.Text;
                ws.Cells[56, col] = energyDifferenceLabel.Text;
                ws.Cells[57, col] = particleSizeLabel.Text;
                ws.Cells[58, col] = "Cost Result".ToUpper();
                ws.Cells[59, col] = DrillingRequiredLabel.Text;
                ws.Cells[60, col] = DrillingCostLabel.Text;
                ws.Cells[61, col] = TotalExploWeightLabel.Text;
                ws.Cells[62, col] = explosiveCostLabel.Text;
                ws.Cells[63, col] = InitialCostLabel.Text;
                ws.Cells[64, col] = laborCostLabel.Text;
                ws.Cells[65, col] = MiscCostLabel.Text;
                ws.Cells[66, col] = TotalCostLabel.Text;
                ws.Cells[67, col] = CostDifferenceLabel.Text;
                ws.Cells[68, col] = TotalUnitCostLabel.Text;
                ws.Cells[69, col] = DifferenceLabel.Text;
                ws.Cells[70, col] = DrillingCostPercentLabel.Text;
                ws.Cells[71, col] = ExplosiveCostPercentLabel.Text;
                ws.Cells[72, col] = InitialCostPercentLabel.Text;
                ws.Cells[73, col] = LaborCostPercentLabel.Text;

                col++;
            }

            

        }

        //function for Dark Theme

        private void DarkTheme()
        {

            //for pannels
            foreach (Control crl in panel11.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }

            //for pannels
            foreach (Control crl in panel1.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }

            foreach (Control crl in panel10.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }

            foreach (Control crl in panel27.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }

            foreach (Control crl in panel29.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }
            foreach (Control crl in panel24.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }

            foreach (Control crl in panel6.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }


            //for labels
            heading1.ForeColor = System.Drawing.Color.RoyalBlue;
            heading2.ForeColor = System.Drawing.Color.RoyalBlue;
            heading3.ForeColor = System.Drawing.Color.RoyalBlue;
            heading4.ForeColor = System.Drawing.Color.RoyalBlue;
            heading5.ForeColor = System.Drawing.Color.RoyalBlue;
            heading6.ForeColor = System.Drawing.Color.RoyalBlue;

           

            foreach (Control crl in panel3.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel25.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel26.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel30.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel5.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel27.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel24.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel29.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }

            foreach (Control crl in panel12.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel16.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel17.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }
            foreach (Control crl in panel18.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Silver;
            }

            foreach (Control crl in panel19.Controls)
            {
                crl.ForeColor = System.Drawing.Color.RoyalBlue;
            }
            foreach (Control crl in panel20.Controls)
            {
                crl.ForeColor = System.Drawing.Color.RoyalBlue;
            }

            foreach (Control crl in panel21.Controls)
            {
                crl.ForeColor = System.Drawing.Color.RoyalBlue;
            }

            //for textboxes
            foreach (Control crl in panel22.Controls)
            {
                crl.ForeColor = System.Drawing.Color.White;
            }
            foreach (Control crl in panel23.Controls)
            {
                crl.ForeColor = System.Drawing.Color.White;
            }


            DrillingCostperMetreTxt.ForeColor = System.Drawing.Color.White;
            LaborCostperholeTxt.ForeColor = System.Drawing.Color.White;
            MiscellaneousperholeTxt.ForeColor = System.Drawing.Color.White;
            

        }

        //function for white theme
        private void WhiteTheme()
        {

            foreach (Control crl in panel11.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }

            foreach (Control crl in panel1.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }

            foreach (Control crl in panel10.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }


            foreach (Control crl in panel6.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }
            foreach (Control crl in panel24.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }
            foreach (Control crl in panel27.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }
            foreach (Control crl in panel29.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }

            //for labels
            heading1.ForeColor = System.Drawing.Color.MediumBlue;
            heading2.ForeColor = System.Drawing.Color.MediumBlue;
            heading3.ForeColor = System.Drawing.Color.MediumBlue;
            heading4.ForeColor = System.Drawing.Color.MediumBlue;
            heading5.ForeColor = System.Drawing.Color.MediumBlue;
            heading6.ForeColor = System.Drawing.Color.MediumBlue;

            

            foreach (Control crl in panel3.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }

            foreach (Control crl in panel25.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }

            foreach (Control crl in panel26.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel30.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }

            foreach (Control crl in panel5.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }

            foreach (Control crl in panel27.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel24.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel29.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel12.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel16.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel17.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel18.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }

            foreach (Control crl in panel19.Controls)
            {
                crl.ForeColor = System.Drawing.Color.MediumBlue;
            }
            foreach (Control crl in panel20.Controls)
            {
                crl.ForeColor = System.Drawing.Color.MediumBlue;
            }

            foreach (Control crl in panel21.Controls)
            {
                crl.ForeColor = System.Drawing.Color.MediumBlue;
            }

           
            //for textboxes
            foreach (Control crl in panel22.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }
            foreach (Control crl in panel23.Controls)
            {
                crl.ForeColor = System.Drawing.Color.Black;
            }


            DrillingCostperMetreTxt.ForeColor = System.Drawing.Color.Black;
            LaborCostperholeTxt.ForeColor = System.Drawing.Color.Black;
            MiscellaneousperholeTxt.ForeColor = System.Drawing.Color.Black;
            

        }

        public static bool changeThemeToWhite = false;
        public static bool changeThemeToDark = false;
        public static bool saveData = false;
        public static bool refreshPage = false;

        private void ActivityTimer_Tick(object sender, EventArgs e)
        {
            if (changeThemeToWhite == true)
            {
                changeThemeToWhite = false;
                WhiteTheme();
            }

            if (changeThemeToDark == true)
            {
                changeThemeToDark = false;
                DarkTheme();
            }

            if (saveData == true)
            {
                saveData = false;
                SaveExeclFile();
            }

            if (refreshPage == true)
            {
                refreshPage = false;
                refresh();
            }

        }

        private void refresh()
        {
            if (MessageBox.Show("Are you sure you want to reset the Entire System? The entered Data will be erased.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //stop the timer
                timer1.Stop();
                //reset all calculated values
                charge_length = 0.00;
                blast_tonnes = 0.00;
                volume_of_blast_hole = 0.00;
                mass_of_exprosive_per_hole = 0.00;
                vertical_length_of_angle_holes = 0.00;
              
                volume_of_material_blasted = 0.00;
                amount_of_explosive = 0.00;
                cost_of_drilling = 0.00;
                cost_of_blasting = 0.00;
                hole_length = 0.00;
                area_available = 0.00;
                drilling_and_blasting_area = 0.00;
                repeatitive_op_number = 0;
               
                diameterOfHole = 0.00;

                drillingRequired = 0.00;
                drillingCost = 0.00;
                totalExploWeight = 0.00;
                ExplosiveCOst = 0.00;
                InitiationCost = 0.00;
                laborCost = 0.00;
                MisceleniousCost = 0.00;
                TotalCost = 0.00;
                CostDifference = 0.00;
                TotalUnitCost = 0.00;
                TotalUnitDifference = 0.00;
                drillingCOstPercent = 0.00;
                ExposiveCostPercent = 0.00;
                InitiationCostPerent = 0.00;
                LaborCostPercent = 0.00;
                numberOfHoles = 0;


                anfoBox = 0;
                //explogelBox = 0;
                boosterPiece = 0;

                //clear all textFields 
                Diameter_of_the_hole.Text = "";
                length_of_area_available.Text = "";
                width_of_the_area_available.Text = "";
                drilling_and_blasing_area_width.Text = "";
                drilling_and_blasting_area_length.Text = "";
                
                //Volume_of_materials_blasted.Text = "";
                Density_of_the_rock.Text = "";
                Explosive_density.Text = "";
                explosiveEnergTxt.Text = "";

                AngleSubtendedVerticallyTxt.Text = "";
                bounderTxt.Text = "";
                DfromTxt.Text = "";
                DrillingCostperMetreTxt.Text = "";
                DtoTxt.Text = "";
                ExplosiveCostperKgTxt.Text = "";
                FinesTxt.Text = "";
                InitialCostperholeTxt.Text = "";
                LaborCostperholeTxt.Text = "";
                MiscellaneousperholeTxt.Text = "";
                benchHEightTxt.Text = "";
                burdenTxt.Text = "";
                steamingTxt.Text = "";
                subdrilTxt.Text = "";
                spacingTxt.Text = "";
                ProductionUnitsRequiredTxt.Text = "";
                rockFactorTxt.Text = "";
                RWStxt.Text = "";
                loadingDensityLabel.Text = "Loading...";
                energyDistLabel.Text = "Loading...";



                plannedProductionTxt.Text = "";

                //start the time
                timer1.Start();
            }
            else
            {

            }
        }

        private void PhaseTwo_Load(object sender, EventArgs e)
        {
            timer1.Start();
            activityTimer.Start();
            loadingDensityLabel.Text = "Loading...";
            energyDistLabel.Text = "Loading...";
        }
    }
}
