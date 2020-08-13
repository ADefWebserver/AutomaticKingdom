/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<StandardMaterialDefines>))]
    public class StandardMaterialDefines : MaterialDefines, IImageProcessingConfigurationDefines
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public async ValueTask<bool> get_MAINUV1()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MAINUV1"
                );
        }
        public ValueTask set_MAINUV1(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAINUV1",
                    value
                );
        }

        
        public async ValueTask<bool> get_MAINUV2()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MAINUV2"
                );
        }
        public ValueTask set_MAINUV2(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAINUV2",
                    value
                );
        }

        
        public async ValueTask<bool> get_DIFFUSE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DIFFUSE"
                );
        }
        public ValueTask set_DIFFUSE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DIFFUSE",
                    value
                );
        }

        
        public async ValueTask<decimal> get_DIFFUSEDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DIFFUSEDIRECTUV"
                );
        }
        public ValueTask set_DIFFUSEDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DIFFUSEDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_AMBIENT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "AMBIENT"
                );
        }
        public ValueTask set_AMBIENT(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "AMBIENT",
                    value
                );
        }

        
        public async ValueTask<decimal> get_AMBIENTDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "AMBIENTDIRECTUV"
                );
        }
        public ValueTask set_AMBIENTDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "AMBIENTDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_OPACITY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OPACITY"
                );
        }
        public ValueTask set_OPACITY(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITY",
                    value
                );
        }

        
        public async ValueTask<decimal> get_OPACITYDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "OPACITYDIRECTUV"
                );
        }
        public ValueTask set_OPACITYDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITYDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_OPACITYRGB()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OPACITYRGB"
                );
        }
        public ValueTask set_OPACITYRGB(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITYRGB",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTION"
                );
        }
        public ValueTask set_REFLECTION(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTION",
                    value
                );
        }

        
        public async ValueTask<bool> get_EMISSIVE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EMISSIVE"
                );
        }
        public ValueTask set_EMISSIVE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVE",
                    value
                );
        }

        
        public async ValueTask<decimal> get_EMISSIVEDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "EMISSIVEDIRECTUV"
                );
        }
        public ValueTask set_EMISSIVEDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVEDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_SPECULAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULAR"
                );
        }
        public ValueTask set_SPECULAR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULAR",
                    value
                );
        }

        
        public async ValueTask<decimal> get_SPECULARDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SPECULARDIRECTUV"
                );
        }
        public ValueTask set_SPECULARDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULARDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_BUMP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "BUMP"
                );
        }
        public ValueTask set_BUMP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BUMP",
                    value
                );
        }

        
        public async ValueTask<decimal> get_BUMPDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BUMPDIRECTUV"
                );
        }
        public ValueTask set_BUMPDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BUMPDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_PARALLAX()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "PARALLAX"
                );
        }
        public ValueTask set_PARALLAX(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PARALLAX",
                    value
                );
        }

        
        public async ValueTask<bool> get_PARALLAXOCCLUSION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "PARALLAXOCCLUSION"
                );
        }
        public ValueTask set_PARALLAXOCCLUSION(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PARALLAXOCCLUSION",
                    value
                );
        }

        
        public async ValueTask<bool> get_SPECULAROVERALPHA()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULAROVERALPHA"
                );
        }
        public ValueTask set_SPECULAROVERALPHA(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULAROVERALPHA",
                    value
                );
        }

        
        public async ValueTask<bool> get_CLIPPLANE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE"
                );
        }
        public ValueTask set_CLIPPLANE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE",
                    value
                );
        }

        
        public async ValueTask<bool> get_CLIPPLANE2()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE2"
                );
        }
        public ValueTask set_CLIPPLANE2(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE2",
                    value
                );
        }

        
        public async ValueTask<bool> get_CLIPPLANE3()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE3"
                );
        }
        public ValueTask set_CLIPPLANE3(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE3",
                    value
                );
        }

        
        public async ValueTask<bool> get_CLIPPLANE4()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE4"
                );
        }
        public ValueTask set_CLIPPLANE4(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE4",
                    value
                );
        }

        
        public async ValueTask<bool> get_CLIPPLANE5()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE5"
                );
        }
        public ValueTask set_CLIPPLANE5(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE5",
                    value
                );
        }

        
        public async ValueTask<bool> get_CLIPPLANE6()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE6"
                );
        }
        public ValueTask set_CLIPPLANE6(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE6",
                    value
                );
        }

        
        public async ValueTask<bool> get_ALPHATEST()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ALPHATEST"
                );
        }
        public ValueTask set_ALPHATEST(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ALPHATEST",
                    value
                );
        }

        
        public async ValueTask<bool> get_DEPTHPREPASS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DEPTHPREPASS"
                );
        }
        public ValueTask set_DEPTHPREPASS(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEPTHPREPASS",
                    value
                );
        }

        
        public async ValueTask<bool> get_ALPHAFROMDIFFUSE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ALPHAFROMDIFFUSE"
                );
        }
        public ValueTask set_ALPHAFROMDIFFUSE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ALPHAFROMDIFFUSE",
                    value
                );
        }

        
        public async ValueTask<bool> get_POINTSIZE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "POINTSIZE"
                );
        }
        public ValueTask set_POINTSIZE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "POINTSIZE",
                    value
                );
        }

        
        public async ValueTask<bool> get_FOG()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "FOG"
                );
        }
        public ValueTask set_FOG(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FOG",
                    value
                );
        }

        
        public async ValueTask<bool> get_SPECULARTERM()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULARTERM"
                );
        }
        public ValueTask set_SPECULARTERM(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULARTERM",
                    value
                );
        }

        
        public async ValueTask<bool> get_DIFFUSEFRESNEL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DIFFUSEFRESNEL"
                );
        }
        public ValueTask set_DIFFUSEFRESNEL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DIFFUSEFRESNEL",
                    value
                );
        }

        
        public async ValueTask<bool> get_OPACITYFRESNEL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OPACITYFRESNEL"
                );
        }
        public ValueTask set_OPACITYFRESNEL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITYFRESNEL",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONFRESNEL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONFRESNEL"
                );
        }
        public ValueTask set_REFLECTIONFRESNEL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONFRESNEL",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFRACTIONFRESNEL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFRACTIONFRESNEL"
                );
        }
        public ValueTask set_REFRACTIONFRESNEL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFRACTIONFRESNEL",
                    value
                );
        }

        
        public async ValueTask<bool> get_EMISSIVEFRESNEL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EMISSIVEFRESNEL"
                );
        }
        public ValueTask set_EMISSIVEFRESNEL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVEFRESNEL",
                    value
                );
        }

        
        public async ValueTask<bool> get_FRESNEL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "FRESNEL"
                );
        }
        public ValueTask set_FRESNEL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FRESNEL",
                    value
                );
        }

        
        public async ValueTask<bool> get_NORMAL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "NORMAL"
                );
        }
        public ValueTask set_NORMAL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NORMAL",
                    value
                );
        }

        
        public async ValueTask<bool> get_UV1()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "UV1"
                );
        }
        public ValueTask set_UV1(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UV1",
                    value
                );
        }

        
        public async ValueTask<bool> get_UV2()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "UV2"
                );
        }
        public ValueTask set_UV2(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UV2",
                    value
                );
        }

        
        public async ValueTask<bool> get_VERTEXCOLOR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VERTEXCOLOR"
                );
        }
        public ValueTask set_VERTEXCOLOR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VERTEXCOLOR",
                    value
                );
        }

        
        public async ValueTask<bool> get_VERTEXALPHA()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VERTEXALPHA"
                );
        }
        public ValueTask set_VERTEXALPHA(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VERTEXALPHA",
                    value
                );
        }

        
        public async ValueTask<decimal> get_NUM_BONE_INFLUENCERS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUM_BONE_INFLUENCERS"
                );
        }
        public ValueTask set_NUM_BONE_INFLUENCERS(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NUM_BONE_INFLUENCERS",
                    value
                );
        }

        
        public async ValueTask<decimal> get_BonesPerMesh()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BonesPerMesh"
                );
        }
        public ValueTask set_BonesPerMesh(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BonesPerMesh",
                    value
                );
        }

        
        public async ValueTask<bool> get_BONETEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "BONETEXTURE"
                );
        }
        public ValueTask set_BONETEXTURE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BONETEXTURE",
                    value
                );
        }

        
        public async ValueTask<bool> get_INSTANCES()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "INSTANCES"
                );
        }
        public ValueTask set_INSTANCES(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "INSTANCES",
                    value
                );
        }

        
        public async ValueTask<bool> get_GLOSSINESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "GLOSSINESS"
                );
        }
        public ValueTask set_GLOSSINESS(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GLOSSINESS",
                    value
                );
        }

        
        public async ValueTask<bool> get_ROUGHNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ROUGHNESS"
                );
        }
        public ValueTask set_ROUGHNESS(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ROUGHNESS",
                    value
                );
        }

        
        public async ValueTask<bool> get_EMISSIVEASILLUMINATION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EMISSIVEASILLUMINATION"
                );
        }
        public ValueTask set_EMISSIVEASILLUMINATION(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVEASILLUMINATION",
                    value
                );
        }

        
        public async ValueTask<bool> get_LINKEMISSIVEWITHDIFFUSE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "LINKEMISSIVEWITHDIFFUSE"
                );
        }
        public ValueTask set_LINKEMISSIVEWITHDIFFUSE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LINKEMISSIVEWITHDIFFUSE",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONFRESNELFROMSPECULAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONFRESNELFROMSPECULAR"
                );
        }
        public ValueTask set_REFLECTIONFRESNELFROMSPECULAR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONFRESNELFROMSPECULAR",
                    value
                );
        }

        
        public async ValueTask<bool> get_LIGHTMAP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "LIGHTMAP"
                );
        }
        public ValueTask set_LIGHTMAP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LIGHTMAP",
                    value
                );
        }

        
        public async ValueTask<decimal> get_LIGHTMAPDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LIGHTMAPDIRECTUV"
                );
        }
        public ValueTask set_LIGHTMAPDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LIGHTMAPDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<bool> get_OBJECTSPACE_NORMALMAP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OBJECTSPACE_NORMALMAP"
                );
        }
        public ValueTask set_OBJECTSPACE_NORMALMAP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OBJECTSPACE_NORMALMAP",
                    value
                );
        }

        
        public async ValueTask<bool> get_USELIGHTMAPASSHADOWMAP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "USELIGHTMAPASSHADOWMAP"
                );
        }
        public ValueTask set_USELIGHTMAPASSHADOWMAP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "USELIGHTMAPASSHADOWMAP",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_3D"
                );
        }
        public ValueTask set_REFLECTIONMAP_3D(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_3D",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_SPHERICAL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_SPHERICAL"
                );
        }
        public ValueTask set_REFLECTIONMAP_SPHERICAL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_SPHERICAL",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_PLANAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_PLANAR"
                );
        }
        public ValueTask set_REFLECTIONMAP_PLANAR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_PLANAR",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_CUBIC()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_CUBIC"
                );
        }
        public ValueTask set_REFLECTIONMAP_CUBIC(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_CUBIC",
                    value
                );
        }

        
        public async ValueTask<bool> get_USE_LOCAL_REFLECTIONMAP_CUBIC()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "USE_LOCAL_REFLECTIONMAP_CUBIC"
                );
        }
        public ValueTask set_USE_LOCAL_REFLECTIONMAP_CUBIC(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "USE_LOCAL_REFLECTIONMAP_CUBIC",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_PROJECTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_PROJECTION"
                );
        }
        public ValueTask set_REFLECTIONMAP_PROJECTION(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_PROJECTION",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_SKYBOX()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_SKYBOX"
                );
        }
        public ValueTask set_REFLECTIONMAP_SKYBOX(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_SKYBOX",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_EXPLICIT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_EXPLICIT"
                );
        }
        public ValueTask set_REFLECTIONMAP_EXPLICIT(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_EXPLICIT",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_EQUIRECTANGULAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR"
                );
        }
        public ValueTask set_REFLECTIONMAP_EQUIRECTANGULAR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_EQUIRECTANGULAR_FIXED()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR_FIXED"
                );
        }
        public ValueTask set_REFLECTIONMAP_EQUIRECTANGULAR_FIXED(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR_FIXED",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED"
                );
        }
        public ValueTask set_REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED",
                    value
                );
        }

        
        public async ValueTask<bool> get_INVERTCUBICMAP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "INVERTCUBICMAP"
                );
        }
        public ValueTask set_INVERTCUBICMAP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "INVERTCUBICMAP",
                    value
                );
        }

        
        public async ValueTask<bool> get_LOGARITHMICDEPTH()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "LOGARITHMICDEPTH"
                );
        }
        public ValueTask set_LOGARITHMICDEPTH(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LOGARITHMICDEPTH",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFRACTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFRACTION"
                );
        }
        public ValueTask set_REFRACTION(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFRACTION",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFRACTIONMAP_3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFRACTIONMAP_3D"
                );
        }
        public ValueTask set_REFRACTIONMAP_3D(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFRACTIONMAP_3D",
                    value
                );
        }

        
        public async ValueTask<bool> get_REFLECTIONOVERALPHA()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONOVERALPHA"
                );
        }
        public ValueTask set_REFLECTIONOVERALPHA(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONOVERALPHA",
                    value
                );
        }

        
        public async ValueTask<bool> get_TWOSIDEDLIGHTING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TWOSIDEDLIGHTING"
                );
        }
        public ValueTask set_TWOSIDEDLIGHTING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TWOSIDEDLIGHTING",
                    value
                );
        }

        
        public async ValueTask<bool> get_SHADOWFLOAT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SHADOWFLOAT"
                );
        }
        public ValueTask set_SHADOWFLOAT(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SHADOWFLOAT",
                    value
                );
        }

        
        public async ValueTask<bool> get_MORPHTARGETS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS"
                );
        }
        public ValueTask set_MORPHTARGETS(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS",
                    value
                );
        }

        
        public async ValueTask<bool> get_MORPHTARGETS_NORMAL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_NORMAL"
                );
        }
        public ValueTask set_MORPHTARGETS_NORMAL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_NORMAL",
                    value
                );
        }

        
        public async ValueTask<bool> get_MORPHTARGETS_TANGENT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_TANGENT"
                );
        }
        public ValueTask set_MORPHTARGETS_TANGENT(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_TANGENT",
                    value
                );
        }

        
        public async ValueTask<bool> get_MORPHTARGETS_UV()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_UV"
                );
        }
        public ValueTask set_MORPHTARGETS_UV(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_UV",
                    value
                );
        }

        
        public async ValueTask<decimal> get_NUM_MORPH_INFLUENCERS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUM_MORPH_INFLUENCERS"
                );
        }
        public ValueTask set_NUM_MORPH_INFLUENCERS(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NUM_MORPH_INFLUENCERS",
                    value
                );
        }

        
        public async ValueTask<bool> get_NONUNIFORMSCALING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "NONUNIFORMSCALING"
                );
        }
        public ValueTask set_NONUNIFORMSCALING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NONUNIFORMSCALING",
                    value
                );
        }

        
        public async ValueTask<bool> get_PREMULTIPLYALPHA()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "PREMULTIPLYALPHA"
                );
        }
        public ValueTask set_PREMULTIPLYALPHA(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PREMULTIPLYALPHA",
                    value
                );
        }

        
        public async ValueTask<bool> get_IMAGEPROCESSING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSING"
                );
        }
        public ValueTask set_IMAGEPROCESSING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSING",
                    value
                );
        }

        
        public async ValueTask<bool> get_VIGNETTE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTE"
                );
        }
        public ValueTask set_VIGNETTE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTE",
                    value
                );
        }

        
        public async ValueTask<bool> get_VIGNETTEBLENDMODEMULTIPLY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY"
                );
        }
        public ValueTask set_VIGNETTEBLENDMODEMULTIPLY(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY",
                    value
                );
        }

        
        public async ValueTask<bool> get_VIGNETTEBLENDMODEOPAQUE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE"
                );
        }
        public ValueTask set_VIGNETTEBLENDMODEOPAQUE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE",
                    value
                );
        }

        
        public async ValueTask<bool> get_TONEMAPPING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING"
                );
        }
        public ValueTask set_TONEMAPPING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING",
                    value
                );
        }

        
        public async ValueTask<bool> get_TONEMAPPING_ACES()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING_ACES"
                );
        }
        public ValueTask set_TONEMAPPING_ACES(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING_ACES",
                    value
                );
        }

        
        public async ValueTask<bool> get_CONTRAST()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CONTRAST"
                );
        }
        public ValueTask set_CONTRAST(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CONTRAST",
                    value
                );
        }

        
        public async ValueTask<bool> get_COLORCURVES()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORCURVES"
                );
        }
        public ValueTask set_COLORCURVES(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORCURVES",
                    value
                );
        }

        
        public async ValueTask<bool> get_COLORGRADING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING"
                );
        }
        public ValueTask set_COLORGRADING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING",
                    value
                );
        }

        
        public async ValueTask<bool> get_COLORGRADING3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING3D"
                );
        }
        public ValueTask set_COLORGRADING3D(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING3D",
                    value
                );
        }

        
        public async ValueTask<bool> get_SAMPLER3DGREENDEPTH()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH"
                );
        }
        public ValueTask set_SAMPLER3DGREENDEPTH(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH",
                    value
                );
        }

        
        public async ValueTask<bool> get_SAMPLER3DBGRMAP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DBGRMAP"
                );
        }
        public ValueTask set_SAMPLER3DBGRMAP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DBGRMAP",
                    value
                );
        }

        
        public async ValueTask<bool> get_IMAGEPROCESSINGPOSTPROCESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS"
                );
        }
        public ValueTask set_IMAGEPROCESSINGPOSTPROCESS(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS",
                    value
                );
        }

        
        public async ValueTask<bool> get_MULTIVIEW()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MULTIVIEW"
                );
        }
        public ValueTask set_MULTIVIEW(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MULTIVIEW",
                    value
                );
        }

        
        public async ValueTask<bool> get_IS_REFLECTION_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IS_REFLECTION_LINEAR"
                );
        }
        public ValueTask set_IS_REFLECTION_LINEAR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IS_REFLECTION_LINEAR",
                    value
                );
        }

        
        public async ValueTask<bool> get_IS_REFRACTION_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IS_REFRACTION_LINEAR"
                );
        }
        public ValueTask set_IS_REFRACTION_LINEAR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IS_REFRACTION_LINEAR",
                    value
                );
        }

        
        public async ValueTask<bool> get_EXPOSURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EXPOSURE"
                );
        }
        public ValueTask set_EXPOSURE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EXPOSURE",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public StandardMaterialDefines() : base() { }

        public StandardMaterialDefines(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask setReflectionMode(string modeToEnable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setReflectionMode" }, modeToEnable
                }
            );
        }
        #endregion
    }
}