/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID BUZZ = 1545069278U;
        static const AkUniqueID DEATH_EVENT = 3150300228U;
        static const AkUniqueID DIRT_EVENT = 3218625211U;
        static const AkUniqueID DRUM_AND_BASS_EVENT = 1955262086U;
        static const AkUniqueID EAT_CARROT = 3024221945U;
        static const AkUniqueID FOOTSTEP = 1866025847U;
        static const AkUniqueID FOOTSTEP_EVENT = 116178158U;
        static const AkUniqueID GRASS_EVENT = 3890470156U;
        static const AkUniqueID GRAVEL_EVENT = 2830206093U;
        static const AkUniqueID MELODY_EVENT = 2183782904U;
        static const AkUniqueID METAL_EVENT = 656197135U;
        static const AkUniqueID PULL_CARROT = 712465182U;
        static const AkUniqueID SAND_EVENT = 1380921214U;
        static const AkUniqueID SNOW_EVENT = 695265601U;
        static const AkUniqueID SPEAKER_NO_OCCLUSION_EVENT = 1210888417U;
        static const AkUniqueID SPEAKER_OCCLUSION_EVENT = 3091691547U;
        static const AkUniqueID STONE_EVENT = 3309131369U;
        static const AkUniqueID WOOD_EVENT = 2090041243U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace CAVE
        {
            static const AkUniqueID GROUP = 4122393694U;

            namespace STATE
            {
                static const AkUniqueID FALSE = 2452206122U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TRUE = 3053630529U;
            } // namespace STATE
        } // namespace CAVE

        namespace LIFE_STATE
        {
            static const AkUniqueID GROUP = 707535153U;

            namespace STATE
            {
                static const AkUniqueID ALIVE = 655265632U;
                static const AkUniqueID DEAD = 2044049779U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace LIFE_STATE

        namespace SPEAKER_OCCLUDED
        {
            static const AkUniqueID GROUP = 3457490076U;

            namespace STATE
            {
                static const AkUniqueID FALSE = 2452206122U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TRUE = 3053630529U;
            } // namespace STATE
        } // namespace SPEAKER_OCCLUDED

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEPSURFACE
        {
            static const AkUniqueID GROUP = 466066820U;

            namespace SWITCH
            {
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID GRAVEL = 2185786256U;
                static const AkUniqueID METAL = 2473969246U;
                static const AkUniqueID SAND = 803837735U;
                static const AkUniqueID SNOW = 787898836U;
                static const AkUniqueID STONE = 1216965916U;
                static const AkUniqueID WOOD = 2058049674U;
            } // namespace SWITCH
        } // namespace FOOTSTEPSURFACE

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID BEE_DISTANCE = 1860277923U;
        static const AkUniqueID SPEAKER_DISTANCE = 1954255994U;
        static const AkUniqueID SPEAKER_EMITTER_ANGLE = 2295050251U;
        static const AkUniqueID SPEAKER_LISTENER_ANGLE = 1217018071U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID FOOTSTEP_TRIGGER = 1283900866U;
        static const AkUniqueID GRASS_TRIGGER = 4196185040U;
        static const AkUniqueID GRAVEL_TRIGGER = 2859233241U;
        static const AkUniqueID METAL_TRIGGER = 2115218395U;
        static const AkUniqueID SAND_TRIGGER = 2657709170U;
        static const AkUniqueID SNOW_TRIGGER = 331148357U;
        static const AkUniqueID STONE_TRIGGER = 1158204429U;
        static const AkUniqueID WOOD_TRIGGER = 1485923599U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID EVENTS = 1381315342U;
        static const AkUniqueID FOOTSTEPS = 2385628198U;
        static const AkUniqueID MAIN = 3161908922U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID CAVE = 4122393694U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
