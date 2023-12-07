using Aspose.Drawing;
using Aspose.OCR.Models.PreprocessingFilters;
using System.Collections.Generic;

namespace Aspose.OCR.Example
{
    class HelpService
    {
     

        internal static System.Drawing.Image DrawRectangles(System.Drawing.Image image,
           System.Drawing.Color c, List<Aspose.Drawing.Rectangle> rects, float angle)
        {
            System.Drawing.Bitmap tempBitmap = new System.Drawing.Bitmap(image.Width, image.Height);
            tempBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (System.Drawing.Graphics gBmp = System.Drawing.Graphics.FromImage(tempBitmap))
            {
                // Draw the original bitmap onto the graphics of the new bitmap
                gBmp.DrawImage(image, 0, 0);


                System.Drawing.Pen pen = new System.Drawing.Pen(c, 1f);
                //move rotation point to center of image
                gBmp.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);
                //rotate
                gBmp.RotateTransform(angle);
                //move image back
                gBmp.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);
                //draw passed in image onto graphics object


                foreach (Aspose.Drawing.Rectangle rect in rects)
                {
                    gBmp.DrawRectangle(pen, new System.Drawing.Rectangle(rect.X, rect.Y, rect.Width, rect.Height));
                }
                pen.Dispose();
            }

            return tempBitmap;
        }

        public static Bitmap RotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }

        Dictionary<string, Language> checkedListBox = new Dictionary<string, Language>();

        internal static Dictionary<string, Language> AddAlphabet()
        {
            Dictionary<string, Language> languages = new Dictionary<string, Language>() {
               {"Latin (auto-detect)", Language.None },
               { "Cyrillic (auto-detect)" , Language.Cyrillic },
               { "English" , Language.Eng },
               { "German" , Language.Deu },
               { "Portuguese" , Language.Por },
               { "Spanish" , Language.Spa},
               { "French" , Language.Fra},
               { "Italian" , Language.Ita},
               { "Czech" , Language.Cze},
               { "Danish" , Language.Dan},
               { "Dutch" , Language.Dum},
               { "Estonian" , Language.Est},
               { "Finnish" , Language.Fin},
               { "Latvian" , Language.Lav},
               { "Lithuanian" , Language.Lit},
               { "Norwegian" , Language.Nor},
               { "Polish" , Language.Pol},
               { "Romanian" , Language.Rum},
               { "Serbo-Croatian" , Language.Srp_hrv},
               { "Slovak" , Language.Slk},
               { "Slovene" , Language.Slv},
               { "Swedish" , Language.Swe},
               { "Chinese" , Language.Chi},
               { "Belorussian" , Language.Bel},
               { "Bulgarian" , Language.Bul},
               { "Kazakh" , Language.Kaz},
               { "Russian" , Language.Rus},
               { "Serbian" , Language.Srp},
               { "Ukrainian" , Language.Ukr},
               { "Hindi" , Language.Hin}
            };
            return languages;
        }

        internal static Dictionary<string, PreprocessingFilter> AddFilters()
        {
            Dictionary<string, PreprocessingFilter> filters = new Dictionary<string, PreprocessingFilter>() {
                { "Grayscale", PreprocessingFilter.ToGrayscale() },
                { "Deskew", PreprocessingFilter.AutoSkew()},
                { "Binarize", PreprocessingFilter.Binarize()},
                { "Dilate", PreprocessingFilter.Dilate()},
                { "Invert", PreprocessingFilter.Invert()},
                { "Median", PreprocessingFilter.Median()},
                { "Denoise", PreprocessingFilter.AutoDenoising()},
                { "Dewarp", PreprocessingFilter.AutoDewarping()},
                { "Auto contrast", PreprocessingFilter.ContrastCorrectionFilter()}
            };
            return filters;
        }


        internal static int LevenshteinDistance(string firstWord, string secondWord)
        {
            var n = firstWord.Length + 1;
            var m = secondWord.Length + 1;
            var matrixD = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (var i = 0; i < n; i++)
            {
                matrixD[i, 0] = i;
            }

            for (var j = 0; j < m; j++)
            {
                matrixD[0, j] = j;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                    matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,          // del
                                            matrixD[i, j - 1] + insertionCost,         // insert
                                            matrixD[i - 1, j - 1] + substitutionCost); // replace
                }
            }

            return matrixD[n - 1, m - 1];
        }

        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
    }
}
