// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Load sample data
using Analysis_ai;

var sampleData = new MLModel1.ModelInput()
{
    Col0 = @"disgusting.",
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
