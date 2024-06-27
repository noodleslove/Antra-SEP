namespace Assignment2;

public class Color
{
    // Instance variables
    private int red;
    private int green;
    private int blue;
    private int alpha;

    // Constructor that takes red, green, blue, and alpha values
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    // Constructor that takes red, green, and blue values, alpha defaults to 255 (opaque)
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    // Getters and setters for red, green, blue, and alpha values
    public int Red
    {
        get { return red; }
        set { red = value; }
    }

    public int Green
    {
        get { return green; }
        set { green = value; }
    }

    public int Blue
    {
        get { return blue; }
        set { blue = value; }
    }

    public int Alpha
    {
        get { return alpha; }
        set { alpha = value; }
    }

    // Method to get the grayscale value for the color
    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }
}

public class Ball
{
    // Instance variables
    private int size;
    private Color color;
    private int throwCount;

    // Constructor that takes size and color
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Method to pop the ball, changing its size to 0
    public void Pop()
    {
        size = 0;
    }

    // Method to throw the ball, incrementing the throw count if it hasn't been popped
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    // Method to get the number of times the ball has been thrown
    public int GetThrowCount()
    {
        return throwCount;
    }
}