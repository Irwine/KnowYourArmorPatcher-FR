// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class KnowYourEnemy
    {
        public static class LoadScreen
        {
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> kye_brittle => Construct(0x590c);
            public static FormLink<ILoadScreenGetter> kye_fireelemental => Construct(0x590d);
            public static FormLink<ILoadScreenGetter> kye_shockelemental => Construct(0x590e);
            public static FormLink<ILoadScreenGetter> kye_plant => Construct(0x590f);
            public static FormLink<ILoadScreenGetter> kye_vile => Construct(0x5910);
            public static FormLink<ILoadScreenGetter> kye_skeletal => Construct(0x5911);
            public static FormLink<ILoadScreenGetter> kye_trollkin => Construct(0x5912);
            public static FormLink<ILoadScreenGetter> kye_weakwilled => Construct(0x5913);
            public static FormLink<ILoadScreenGetter> kye_weakwilled_2 => Construct(0x5914);
            public static FormLink<ILoadScreenGetter> kye_strongwilled => Construct(0x5915);
            public static FormLink<ILoadScreenGetter> kye_cavedwelling_2 => Construct(0x5917);
            public static FormLink<ILoadScreenGetter> kye_vascular => Construct(0x5918);
            public static FormLink<ILoadScreenGetter> kye_aquatic => Construct(0x5919);
            public static FormLink<ILoadScreenGetter> kye_dwarven_machine => Construct(0xfb69);
            public static FormLink<ILoadScreenGetter> kye_furred => Construct(0x5901);
            public static FormLink<ILoadScreenGetter> kye_fat => Construct(0x5902);
            public static FormLink<ILoadScreenGetter> kye_big => Construct(0x5903);
            public static FormLink<ILoadScreenGetter> kye_small_1 => Construct(0x5904);
            public static FormLink<ILoadScreenGetter> kye_small_2 => Construct(0x5905);
            public static FormLink<ILoadScreenGetter> kye_armored => Construct(0x5906);
            public static FormLink<ILoadScreenGetter> kye_dwarven_machine_2 => Construct(0x5907);
            public static FormLink<ILoadScreenGetter> kye_undead_1 => Construct(0x5908);
            public static FormLink<ILoadScreenGetter> kye_undead_2 => Construct(0x5909);
            public static FormLink<ILoadScreenGetter> kye_venomous => Construct(0x590a);
            public static FormLink<ILoadScreenGetter> kye_iceelemental => Construct(0x590b);
        }
    }
}
