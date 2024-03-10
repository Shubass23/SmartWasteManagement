using SmartWasteManagement.InferenceModel.Yolov5.Scorer.Models.Abstract;

namespace SmartWasteManagement.InferenceModel.Yolov5.Scorer.Models
{
    public record TrashModel() : YoloModel(
        640,
        640,
        3,

        11,

        new[] { 8, 16, 32 },

        new[]
        {
            new[] { new[] { 010, 13 }, new[] { 016, 030 }, new[] { 033, 023 } },
            new[] { new[] { 030, 61 }, new[] { 062, 045 }, new[] { 059, 119 } },
            new[] { new[] { 116, 90 }, new[] { 156, 198 }, new[] { 373, 326 } }
        },

        new[] { 80, 40, 20 },

        0.40f,
        0.40f,
        0.45f,

        new[] { "output0" },

        new()
        {
            //change this according to trained model
            new(0, "BIODEGRADABLE"),
            new(1, "CARDBOARD"),
            new(2, "GLASS"),
            new(3, "METAL"),
            new(4, "PAPER"),
            new(5, "PLASTIC")
        },

        true
    );
}