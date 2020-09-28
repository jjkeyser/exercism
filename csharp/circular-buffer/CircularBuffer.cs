using System;

public class CircularBuffer<T>
{
    private readonly T[] _buffer;
    private int _StartPointer = 0;
    private int _EndPointer = 0;
    private int _CountInBuffer = 0;
    
    public CircularBuffer(int capacity)
    {
        _buffer = new T[capacity];
    }

    public T Read()
    {
        if (_CountInBuffer == 0)
        {
            throw new InvalidOperationException("Can't read an empty buffer");
        }
        T value = _buffer[_StartPointer];
        _StartPointer = (_StartPointer + 1) % _buffer.Length;
        _CountInBuffer --;

        return value;
    }

    public void Write(T value)
    {
        if (_CountInBuffer == _buffer.Length)
        {
            throw new InvalidOperationException("Can't write to a full buffer.");
        }
        _buffer[_EndPointer] = value;
        _EndPointer = (_EndPointer + 1) % _buffer.Length;
        _CountInBuffer ++;
    }

    public void Overwrite(T value)
    {
        if (_CountInBuffer == _buffer.Length)
        {
            _CountInBuffer --;
            _StartPointer = (_StartPointer + 1) % _buffer.Length;
        }
        Write(value);
    }

    public void Clear()
    {
        if (_CountInBuffer > 0)
        {
            Array.Clear(_buffer, _StartPointer, 1);
            _CountInBuffer --;
        }
    }
}