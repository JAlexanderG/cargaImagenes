private static byte[] AddInterleavedZeros(byte[] data)
{
    if (data == null) return Array.Empty<byte>();
    if (data.Length == 0) return data;

    using var ms = new MemoryStream();
    foreach (byte b in data)
    {
        ms.WriteByte(b);     // Escribe el byte original
        ms.WriteByte(0x00);  // Inserta un cero después de cada byte
    }

    return ms.ToArray();
}