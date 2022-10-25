using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotInputMap
    {
        public ImGuiMouseButton Pan;
        public ImGuiKeyModFlags PanMod;
        public ImGuiMouseButton Fit;
        public ImGuiMouseButton Select;
        public ImGuiMouseButton SelectCancel;
        public ImGuiKeyModFlags SelectMod;
        public ImGuiKeyModFlags SelectHorzMod;
        public ImGuiKeyModFlags SelectVertMod;
        public ImGuiMouseButton Menu;
        public ImGuiKeyModFlags OverrideMod;
        public ImGuiKeyModFlags ZoomMod;
        public float ZoomRate;
    }
    public unsafe partial struct ImPlotInputMapPtr
    {
        public ImPlotInputMap* NativePtr { get; }
        public ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => NativePtr = nativePtr;
        public ImPlotInputMapPtr(IntPtr nativePtr) => NativePtr = (ImPlotInputMap*)nativePtr;
        public static implicit operator ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => new ImPlotInputMapPtr(nativePtr);
        public static implicit operator ImPlotInputMap* (ImPlotInputMapPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotInputMapPtr(IntPtr nativePtr) => new ImPlotInputMapPtr(nativePtr);
        public ref ImGuiMouseButton Pan => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Pan);
        public ref ImGuiKeyModFlags PanMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->PanMod);
        public ref ImGuiMouseButton Fit => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Fit);
        public ref ImGuiMouseButton Select => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Select);
        public ref ImGuiMouseButton SelectCancel => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->SelectCancel);
        public ref ImGuiKeyModFlags SelectMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->SelectMod);
        public ref ImGuiKeyModFlags SelectHorzMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->SelectHorzMod);
        public ref ImGuiKeyModFlags SelectVertMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->SelectVertMod);
        public ref ImGuiMouseButton Menu => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Menu);
        public ref ImGuiKeyModFlags OverrideMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->OverrideMod);
        public ref ImGuiKeyModFlags ZoomMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->ZoomMod);
        public ref float ZoomRate => ref Unsafe.AsRef<float>(&NativePtr->ZoomRate);
        public void Destroy()
        {
            ImPlotNative.ImPlotInputMap_destroy((ImPlotInputMap*)(NativePtr));
        }
    }
}
