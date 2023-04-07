class Block
{
    private int[] dimensions;

    public Block(int[] dimensions)
    {
        this.dimensions = dimensions;
    }

    public int get_width()
    {
        return dimensions[0];
    }

    public int get_length()
    {
        return dimensions[1];
    }

    public int get_height()
    {
        return dimensions[2];
    }

    public int get_volume()
    {
        return dimensions[0] * dimensions[1] * dimensions[2];
    }

    public int get_surface_area()
    {
        return 2 * dimensions[0] * dimensions[1] +
               2 * dimensions[0] * dimensions[2] +
               2 * dimensions[1] * dimensions[2];
    }
}
