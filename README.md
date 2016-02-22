# TrayNotification
TrayNotification is a fully flexible popup notification system for use in your projects, either VB or C# since it's written as a lib.

![Demo](http://orig04.deviantart.net/9a33/f/2016/052/2/c/traynot_demo_by_oduslabs-d9sngli.gif)

##About
You can customize almost everything, including:

- Back, tile and text colors
- Display image & its padding
- Animation style and direction (popup/toast, slide from bottom/side)
- Spacing from working screen area
- Animation duration
- Popup lifetime - await dismissal or set custom
- Something else I probably forgot

##Usage
With so many options, it was difficult to design a configuration. Neither a gigantic constructor nor a million properties were desirable. I ended up grouping it into 2x models for the image & coloring, supplying animation flags in the constructor, and duration options via the Show method.

Here's how to set up the color and image models:

```C#
Coloring coloring = new Coloring()
{
    BackColor = Color.White,
    Tile = Control.DefaultBackColor,

    Body = Brushes.Black
};

NotifIcon notifIcon = new NotifIcon()
{
    Image = Image.FromFile(@""),
    Padding = 10
};
```

These are then assigned to properties after you set up the notification:
```C#
var notification = new Notification(Style.Slide, Direction.Up, 500)
{
    Title = "Hello World",
    Body = "Changed my mind, going back inside.",

    Padding = 10,

    Icon = notifIcon,
    Color = coloring
};
```

From there, you can simply call `Show()` as you would on a standard Form (the notification window inherits from Form), optionally supplying a duration to an overload.

If there is a lifetime marked, the user entering their mouse into the region will stop the timer and leaving will resume it. I forgot to include options for direction in the test form. But if it's sliding, you can control which direction it comes from. It will also automatically calculate the exit direction so no need to supply that.

Oh and in terms of licensing. Pretty simple, use it wherever you like but if your application has an about/credits area, please include a link to the repo in it. Just don't attempt to profit from this for the love of god. Enjoy!
