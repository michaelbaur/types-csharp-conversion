namespace ECMAScript.Lib;

public abstract class Union<T1, T2>
{
    public static implicit operator Union<T1, T2>(T1 o) => null!;
    public static implicit operator Union<T1, T2>(T2 o) => null!;
    public static explicit operator T1(Union<T1, T2> u) => default!;
    public static explicit operator T2(Union<T1, T2> u) => default!;
}

public abstract class Union<T1, T2, T3>
{
    public static implicit operator Union<T1, T2, T3>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3> u) => default!;
}

public abstract class Union<T1, T2, T3, T4>
{
    public static implicit operator Union<T1, T2, T3, T4>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4> u) => default!;
}

public abstract class Union<T1, T2, T3, T4, T5>
{
    public static implicit operator Union<T1, T2, T3, T4, T5>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5> u) => default!;
}

public abstract class Union<T1, T2, T3, T4, T5, T6>
{
    public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5, T6> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5, T6> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5, T6> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5, T6> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5, T6> u) => default!;
    public static explicit operator T6(Union<T1, T2, T3, T4, T5, T6> u) => default!;
}
public abstract class Union<T1, T2, T3, T4, T5, T6, T7>
{
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
    public static explicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
    public static explicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7> u) => default!;
}
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8>
{
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
    public static explicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8> u) => default!;
}
public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
    public static explicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> u) => default!;
}

public abstract class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
{
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T6(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T7(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T8(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T9(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
    public static explicit operator T10(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> u) => default!;
}
