﻿using System.Collections.Generic;

namespace App2
{
    public class SketchFeatureExtraction
    {
        public static SketchPoint Centroid(List<SketchStroke> strokes)
        {
            List<SketchPoint> points = new List<SketchPoint>();

            foreach (SketchStroke stroke in strokes) points.AddRange(stroke.Points);

            double meanX = 0.0;
            double meanY = 0.0;

            foreach (SketchPoint point in points)
            {
                meanX += point.X;
                meanY += point.Y;
            }

            meanX /= points.Count;
            meanY /= points.Count;

            return new SketchPoint(meanX, meanY);
        }
    }
}