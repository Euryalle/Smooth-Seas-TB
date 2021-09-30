using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;

namespace StorybrewScripts
{
    public class LyricsKala : StoryboardObjectGenerator
    {
        [Configurable]
        public OsbOrigin LyricsOrigin = OsbOrigin.Centre;

        [Configurable]
        public string FontName = "Almost Serious";

        [Configurable]
        public string OutputPath = "sb/lyrics/kala";

        [Configurable]
        public string CirclePath = "sb/circle.png";

        [Configurable]
        public string StripePath = "sb/stripe.png";

        [Configurable]
        public string LeftEdgePath = "sb/leftEdge.png";

        [Configurable]
        public string RightEdgePath = "sb/rightEdge.png";

        [Configurable]
        public float LetterSpacing = 4f;

        [Configurable]
        public float LyricsFade = 0.8f;

        [Configurable]
        public float LinesFade = 0.7f;

        [Configurable]
        public float CirclesMinFade = 0.1f;

        [Configurable]
        public float CirclesMaxFade = 0.5f;

        [Configurable]
        public bool ShowCircles = true;

        [Configurable]
        public bool ShowLines = true;

        [Configurable]
        public float MinCircleAmount = 3;

        [Configurable]
        public float MaxCircleAmount = 6;

        [Configurable]
        public float CircleMinScale = 0.5f;

        [Configurable]
        public float CircleMaxScale = 1.5f;

        [Configurable]
        public bool RandomRotate = true;

        [Configurable]
        public double CircleMinRotation = 0f;

        [Configurable]
        public double CircleMaxRotation = 1f;

        [Configurable]
        public int FontSize = 26;

        [Configurable]
        public float FontScale = 0.5f;

        [Configurable]
        public Color4 FontColor = Color4.White;

        [Configurable]
        public FontStyle FontStyle = FontStyle.Regular;

        [Configurable]
        public int GlowRadius = 0;

        [Configurable]
        public Color4 GlowColor = new Color4(255, 255, 255, 255);

        [Configurable]
        public bool AdditiveGlow = true;

        [Configurable]
        public int OutlineThickness = 0;

        [Configurable]
        public Color4 OutlineColor = new Color4(50, 50, 50, 200);

        [Configurable]
        public int ShadowThickness = 4;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 200);

        [Configurable]
        public Vector2 Padding = Vector2.Zero;

        [Configurable]
        public bool TrimTransparency = true;

        [Configurable]
        public bool EffectsOnly = false;

        [Configurable]
        public bool Debug = false;

        [Configurable]
        public bool Additive = false;

        [Configurable]
        public Color4 LinesColor = Color4.Cyan;

        [Configurable]
        public Color4 CirclesColor = Color4.White;

        [Configurable]
        public bool RandomLyricsColor = false;

        [Configurable]
        public Color4 MinLyricsColor = new Color4(255, 255, 255, 255);

        [Configurable]
        public Color4 MaxLyricsColor = new Color4(100, 100, 100, 255);

        public override void Generate()
        {
            var font = LoadFont(OutputPath, new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = FontColor,
                Padding = Padding,
                FontStyle = FontStyle,
                TrimTransparency = TrimTransparency,
                EffectsOnly = EffectsOnly,
                Debug = Debug,
            },
            new FontGlow()
            {
                Radius = AdditiveGlow ? 0 : GlowRadius,
                Color = GlowColor,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });

            // Verse 1
            CreateLyrics(font, "The leaves fell off as I did", FontName, FontSize, new Vector2(320, 400), 23107, 25159);
            CreateLyrics(font, "I guess it held some kind of meaning", FontName, FontSize, new Vector2(320, 400), 25317, 27686);
            CreateLyrics(font, "I've been lying in this bed of nails", FontName, FontSize, new Vector2(320, 400), 27844, 30686);
            CreateLyrics(font, "That let the wind out of my sails", FontName, FontSize, new Vector2(320, 400), 30844, 33370);
            CreateLyrics(font, "She left me on the bridge she's burning", FontName, FontSize, new Vector2(320, 400), 33686, 36686);
            CreateLyrics(font, "Hell, maybe I deserve it", FontName, FontSize, new Vector2(320, 400), 37001, 39212);
            CreateLyrics(font, "I'm just trying to find my purpose", FontName, FontSize, new Vector2(320, 400), 39528, 41738);
            CreateLyrics(font, "I hope that it's all worth it", FontName, FontSize, new Vector2(320, 400), 42212, 44738);
            // Bridge 1
            CreateLyrics(font, "There will come a time", FontName, FontSize, new Vector2(320, 400), 45054, 47265);
            CreateLyrics(font, "When you will face your life", FontName, FontSize, new Vector2(320, 400), 47580, 49791);
            CreateLyrics(font, "Don't let it twist and tear you up inside", FontName, FontSize, new Vector2(320, 400), 50186, 53423);
            // Chorus 1
            CreateLyrics(font, "The world's a fucked up place", FontName, FontSize, new Vector2(320, 400), 53738, 55317);
            CreateLyrics(font, "But it depends on how you see it", FontName, FontSize, new Vector2(320, 400), 55475, 58317);
            CreateLyrics(font, "Life is full of change", FontName, FontSize, new Vector2(320, 400), 58712, 60370);
            CreateLyrics(font, "You grow up and then you feel it", FontName, FontSize, new Vector2(320, 400), 60686, 63212);
            CreateLyrics(font, "But smooth seas don't make good sailors", FontName, FontSize, new Vector2(320, 400), 64080, 66370);
            CreateLyrics(font, "Jump ship and head for failure", FontName, FontSize, new Vector2(320, 400), 66686, 68580);
            CreateLyrics(font, "Find yourself a tragedy", FontName, FontSize, new Vector2(320, 400), 68896, 70949);
            CreateLyrics(font, "Slowly lose your sanity", FontName, FontSize, new Vector2(320, 400), 71265, 73949);
            // Verse 2
            CreateLyrics(font, "I'll be alright, your bark was worse than your bite", FontName, FontSize, new Vector2(320, 400), 84054, 88949);
            CreateLyrics(font, "Left a scar that faded with time", FontName, FontSize, new Vector2(320, 400), 89265, 91475);
            CreateLyrics(font, "Echoed out to the back of my mind", FontName, FontSize, new Vector2(320, 400), 91791, 94159);
            // Bridge 2
            CreateLyrics(font, "There will come a time", FontName, FontSize, new Vector2(320, 400), 95580, 97791);
            CreateLyrics(font, "When you will face", FontName, FontSize, new Vector2(320, 400), 98107, 98896);
            // Chorus 2
            CreateLyrics(font, "The world's a fucked up place", FontName, FontSize, new Vector2(320, 400), 99212, 100791);
            CreateLyrics(font, "But it depends on how you see it", FontName, FontSize, new Vector2(320, 400), 100949, 103791);
            CreateLyrics(font, "Life is full of change", FontName, FontSize, new Vector2(320, 400), 104186, 105844);
            CreateLyrics(font, "You grow up and then you feel it", FontName, FontSize, new Vector2(320, 400), 106160, 108686);
            CreateLyrics(font, "But smooth seas don't make good sailors", FontName, FontSize, new Vector2(320, 400), 109554, 111844);
            CreateLyrics(font, "Jump ship and head for failure", FontName, FontSize, new Vector2(320, 400), 112160, 114054);
            CreateLyrics(font, "Find yourself a tragedy", FontName, FontSize, new Vector2(320, 400), 114370, 116423);
            CreateLyrics(font, "Slowly lose your sanity", FontName, FontSize, new Vector2(320, 400), 116739, 119423);
            // Chorus 3
            CreateLyrics(font, "And after walking round in circles", FontName, FontSize, new Vector2(320, 400), 122738, 125107);
            CreateLyrics(font, "Cursed every corner of this town will I make it out", FontName, FontSize, new Vector2(320, 400), 125423, 132054);
            CreateLyrics(font, "And if I do then it's a god send", FontName, FontSize, new Vector2(320, 400), 132844, 135212);
            CreateLyrics(font, "I caught a bullet in between my teeth", FontName, FontSize, new Vector2(320, 400), 135370, 138844);
            CreateLyrics(font, "Could this finally be the end", FontName, FontSize, new Vector2(320, 400), 139001, 144370);
            // Bridge 3
            CreateLyrics(font, "There will come a time", FontName, FontSize, new Vector2(320, 400), 148851, 151146);
            CreateLyrics(font, "When you will face your life", FontName, FontSize, new Vector2(320, 400), 151310, 153605);
            CreateLyrics(font, "Don't let it twist and tear you up inside", FontName, FontSize, new Vector2(320, 400), 154097, 157338);
            // Chorus 3
            CreateLyrics(font, "The world's a fucked up place", FontName, FontSize, new Vector2(320, 400), 157660, 159239);
            CreateLyrics(font, "But it depends on how you see it", FontName, FontSize, new Vector2(320, 400), 159397, 162239);
            CreateLyrics(font, "Life is full of change", FontName, FontSize, new Vector2(320, 400), 162634, 164292);
            CreateLyrics(font, "You grow up and then you feel it", FontName, FontSize, new Vector2(320, 400), 164608, 167134);
            CreateLyrics(font, "But smooth seas don't make good sailors", FontName, FontSize, new Vector2(320, 400), 168002, 170292);
            CreateLyrics(font, "Jump ship and head for failure", FontName, FontSize, new Vector2(320, 400), 170608, 172502);
            CreateLyrics(font, "Find yourself a tragedy", FontName, FontSize, new Vector2(320, 400), 172818, 174871);
            CreateLyrics(font, "Slowly lose your sanity", FontName, FontSize, new Vector2(320, 400), 175187, 177870);
            CreateLyrics(font, "Find yourself a tragedy", FontName, FontSize, new Vector2(320, 400), 177871, 180081);
            CreateLyrics(font, "Slowly lose your sanity", FontName, FontSize, new Vector2(320, 400), 180396, 183633);
        }

        private void CreateLyrics(Vector2 position, int StartTime, int EndTime, float lineWidth, float lineHeight)
        {
            if (ShowCircles)
            {
                var CirclesLayer = GetLayer("Circles");
                for (var i = 0; i < lineWidth * Random(MinCircleAmount, MaxCircleAmount) / 280; i++) //Generate circles
                {
                    var RandomFade = Random(CirclesMinFade, CirclesMaxFade);
                    var CirclePosition = new Vector2(position.X + (float)Random(-(45 * Math.Ceiling(lineWidth / 45) / 2) - (45 / 2), (45 * Math.Ceiling(lineWidth / 45) / 2) + (45 / 2)), position.Y + (lineHeight / 2) + Random(-(45 / 2), (45 / 2)));
                    //var CirclePosition = new Vector2((float)Random(-lineWidth / 2f, lineWidth / 2f), (float)Random(-lineHeight / 2f, lineHeight / 2f)) + position;
                    var circle = CirclesLayer.CreateSprite(CirclePath, OsbOrigin.Centre, CirclePosition);

                    circle.Scale(StartTime, Random(CircleMinScale, CircleMaxScale) / 2f);
                    circle.Fade(StartTime, StartTime + 50 * (Math.Ceiling(lineWidth / 45) + 5), 0, RandomFade);
                    circle.Fade(EndTime, EndTime + 50 * (Math.Ceiling(lineWidth / 45) + 5), RandomFade, 0);
                    circle.Move(StartTime, EndTime + 50 * (Math.Ceiling(lineWidth / 45) + 5), CirclePosition.X, CirclePosition.Y, CirclePosition.X + Random(-16, 16), CirclePosition.Y + Random(-16, 16));
                    circle.Color(StartTime, CirclesColor);

                    if (RandomRotate)
                    {
                        var angle = Random(CircleMinRotation, CircleMaxRotation);
                        circle.Rotate(EndTime, MathHelper.DegreesToRadians(angle));
                    }
                }
            }

            if (ShowLines)
            {
                var LinesLayer = GetLayer("Lines");
                var LeftEdgePosition = new Vector2(position.X - (45 * (float)Math.Ceiling(lineWidth / 45) / 2), position.Y + (lineHeight / 2.5f) + 7);
                var RightEdgePosition = new Vector2(position.X - (45 * (float)Math.Ceiling(lineWidth / 45) / 2) + (45 / 2) + 45 * (float)Math.Ceiling(lineWidth / 45) - (45 / 2), position.Y + (lineHeight / 2) - 7);
                for (int i = 0; i < Math.Ceiling(lineWidth / 45); i++)
                {
                    var StripePosition = new Vector2((float)position.X - (45 * (float)Math.Ceiling(lineWidth / 45) / 2) + (45 / 2) + 45 * i, position.Y + (lineHeight / 2));

                    var stripes = LinesLayer.CreateSprite(StripePath, OsbOrigin.Centre, StripePosition);
                    stripes.ScaleVec(0, StartTime + 50 * (i + 1), StartTime + 50 * (i + 4), 0, 0.5, 0.5, 0.5);
                    stripes.Fade(0, StartTime + 50 * (i + 1), StartTime + 50 * (i + 4), 0, LinesFade);
                    stripes.ScaleVec(0, EndTime + 50 * (i + 1), EndTime + 50 * (i + 4), 0.5, 0.5, 0, 0.5);
                    stripes.Fade(0, EndTime + 50 * (i + 1), EndTime + 50 * (i + 4), LinesFade, 0);
                    stripes.Color(StartTime, LinesColor);
                }

                var LeftEdge = LinesLayer.CreateSprite(LeftEdgePath, OsbOrigin.BottomCentre, LeftEdgePosition);
                LeftEdge.ScaleVec(0, StartTime, StartTime + 50 * 4, 0, 0.5, 0.5, 0.5);
                LeftEdge.Fade(0, StartTime, StartTime + 50 * 4, 0, LinesFade);
                LeftEdge.ScaleVec(0, EndTime, EndTime + 50 * 4, 0.5, 0.5, 0, 0.5);
                LeftEdge.Fade(0, EndTime, EndTime + 50 * 4, LinesFade, 0);
                LeftEdge.Color(StartTime, LinesColor);

                var RightEdge = LinesLayer.CreateSprite(RightEdgePath, OsbOrigin.TopCentre, RightEdgePosition);
                RightEdge.ScaleVec(0, StartTime + 50 * (Math.Ceiling(lineWidth / 45) + 1), StartTime + 50 * (Math.Ceiling(lineWidth / 45) + 4), 0, 0.5, 0.5, 0.5);
                RightEdge.Fade(0, StartTime + 50 * (Math.Ceiling(lineWidth / 45) + 1), StartTime + 50 * (Math.Ceiling(lineWidth / 45) + 4), 0, LinesFade);
                RightEdge.ScaleVec(0, EndTime + 50 * (Math.Ceiling(lineWidth / 45) + 1), EndTime + 50 * (Math.Ceiling(lineWidth / 45) + 4), 0.5, 0.5, 0, 0.5);
                RightEdge.Fade(0, EndTime + 50 * (Math.Ceiling(lineWidth / 45) + 1), EndTime + 50 * (Math.Ceiling(lineWidth / 45) + 4), LinesFade, 0);
                RightEdge.Color(StartTime, LinesColor);
            }
        }


        private void CreateLyrics(FontGenerator font, string Sentence, string FontName, int FontSize, Vector2 position, int StartTime, int EndTime)
        {
            var LyricsLayer = GetLayer("Lyrics");
            var letterY = position.Y;
            var lineWidth = 0f;
            var lineHeight = 0f;
            var letterSpacing = LetterSpacing * FontScale;
            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * FontScale + letterSpacing;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
            }

            CreateLyrics(position, StartTime, EndTime, lineWidth, lineHeight);
            var letterX = position.X - lineWidth * 0.5f;
            var timePerLetter = 60;
            var i = 0;
            double Beat = Beatmap.GetTimingPointAt(StartTime).BeatDuration;
            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var letterPos = new Vector2(letterX, letterY)
                        + texture.OffsetFor(LyricsOrigin) * FontScale;

                    var sprite = LyricsLayer.CreateSprite(texture.Path, LyricsOrigin, letterPos);
                    sprite.ScaleVec(StartTime, FontScale,FontScale);
                    //sprite.ScaleVec(OsbEasing.InBack, EndTime - Beat * 2, EndTime, FontScale, FontScale, FontScale, -0);
                    //sprite.Fade(StartTime + timePerLetter * i, StartTime + 200 + timePerLetter * i, 0, LyricsFade);
                    sprite.Fade(StartTime, StartTime + Beat, 0, LyricsFade);
                    sprite.Fade(EndTime - Beat, EndTime, LyricsFade, 0);
                    //sprite.MoveX(OsbEasing.OutBack, StartTime, StartTime + Beat * 2, letterCenter, letterPos.X);  
                    //sprite.MoveY(StartTime, letterY);

                    if (Additive)
                    {
                        sprite.Additive(StartTime, EndTime);
                    }

                    var RealColor1 = RandomLyricsColor ? new Color4((float)Random(MinLyricsColor.R, MaxLyricsColor.R),
                                                                (float)Random(MinLyricsColor.G, MaxLyricsColor.G),
                                                                (float)Random(MinLyricsColor.B, MaxLyricsColor.B), 255) : MinLyricsColor;
                    var RealColor2 = RandomLyricsColor ? new Color4((float)Random(MinLyricsColor.R, MaxLyricsColor.R),
                                                                (float)Random(MinLyricsColor.G, MaxLyricsColor.G),
                                                                (float)Random(MinLyricsColor.B, MaxLyricsColor.B), 255) : MaxLyricsColor;

                    sprite.Color(StartTime, EndTime, RealColor1, RealColor2);
                    i++;
                }
                letterX += texture.BaseWidth * FontScale + letterSpacing;
            }
            letterY += lineHeight;

            //var position = new Vector2(SubtitleX - texture.BaseWidth * FontScale * 0.5f, SubtitleY)
            //    + texture.OffsetFor(Origin) * FontScale;
        }
    }
}
