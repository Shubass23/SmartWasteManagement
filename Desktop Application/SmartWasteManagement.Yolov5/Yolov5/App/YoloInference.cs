using SmartWasteManagement.InferenceModel.Yolov5.Scorer;
using SmartWasteManagement.InferenceModel.Yolov5.Scorer.Models;
using System.Drawing;

namespace SmartWasteManagement.InferenceModel.Yolov5.App
{
    public static class YoloInference
    {
        public static (Image, List<YoloPrediction>) DrawBoundingBox(Image image)
        {
            YoloScorer<TrashModel> scorer = new YoloScorer<TrashModel>("D:\\Final Year Project\\src\\SmartWasteManagement\\SmartWasteManagement.Yolov5\\Yolov5\\Assests\\Weights\\latest.onnx");

            List<YoloPrediction> predictions = scorer.Predict(image);

            using var graphics = Graphics.FromImage(image);

            foreach (var prediction in predictions) // iterate predictions to draw results
            {
                double score = Math.Round(prediction.Score, 2);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 1),
                    new[] { prediction.Rectangle });

                var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Arial", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
            }

            return (image, predictions);
        }
    }
  
}

