# Modificadores de acceso

| Modificador de acceso | Descripción |
| --------------------- | ----------- |
| `private` | El miembro es accesible solamente dentro del tipo. Este es el default.|
| `internal` | El miembro es accesible dentro del tipo y cualquier otro tipo en el mismo _assembly_. |
| `protected` | El miembro es accesible dentro del tipo y cualquier tipo que herede de él. |
| `public` | El miembro se puede acceder donde sea. | 
| `internal protected` | El miembro es accesible dentro del tipo, cualquier tipo que herede de él, y cualquier tipo dentro del mismo _assembly_. Es equivalente al modificador de acceso ficticio llamado `internal_or_protected`. |
| `private protected` | El miembro es accesible dentro del tipo, o cualquier tipo que herede de él y esté en el mismo _assembly_. Es equivalente al modificador de acceso ficticio llamado `internal_and_protected`. Esta combinación sólo está disponible en C# 7.2 o posterior. |
