

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace Salami4UAGenNHibernate.CEN.Salami4UA
{
public partial class CharacteristicFeaturesCEN
{
private ICharacteristicFeaturesCAD _ICharacteristicFeaturesCAD;

public CharacteristicFeaturesCEN()
{
        this._ICharacteristicFeaturesCAD = new CharacteristicFeaturesCAD ();
}

public CharacteristicFeaturesCEN(ICharacteristicFeaturesCAD _ICharacteristicFeaturesCAD)
{
        this._ICharacteristicFeaturesCAD = _ICharacteristicFeaturesCAD;
}

public ICharacteristicFeaturesCAD get_ICharacteristicFeaturesCAD ()
{
        return this._ICharacteristicFeaturesCAD;
}

public string New_ (string p_Name)
{
        CharacteristicFeaturesEN characteristicFeaturesEN = null;
        string oid;

        //Initialized CharacteristicFeaturesEN
        characteristicFeaturesEN = new CharacteristicFeaturesEN ();
        characteristicFeaturesEN.Name = p_Name;

        //Call to CharacteristicFeaturesCAD

        oid = _ICharacteristicFeaturesCAD.New_ (characteristicFeaturesEN);
        return oid;
}

public void Modify (string p_CharacteristicFeatures_OID)
{
        CharacteristicFeaturesEN characteristicFeaturesEN = null;

        //Initialized CharacteristicFeaturesEN
        characteristicFeaturesEN = new CharacteristicFeaturesEN ();
        characteristicFeaturesEN.Name = p_CharacteristicFeatures_OID;
        //Call to CharacteristicFeaturesCAD

        _ICharacteristicFeaturesCAD.Modify (characteristicFeaturesEN);
}

public void Destroy (string Name)
{
        _ICharacteristicFeaturesCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> DameTodasLasCaracteristicas ()
{
        return _ICharacteristicFeaturesCAD.DameTodasLasCaracteristicas ();
}
}
}
