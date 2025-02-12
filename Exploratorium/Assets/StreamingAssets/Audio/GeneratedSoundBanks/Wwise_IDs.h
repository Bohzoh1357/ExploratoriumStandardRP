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
        static const AkUniqueID FOOTSTEP = 1866025847U;
        static const AkUniqueID INVENTORY_OPEN = 3325545974U;
        static const AkUniqueID JUMP_LANDING = 2883244301U;
        static const AkUniqueID MOUNTAIN_WIND1 = 1863533814U;
        static const AkUniqueID MOUNTAIN_WIND2 = 1863533813U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID OCEANBACKGROUND = 644435109U;
        static const AkUniqueID OCEANWAVES = 3350388417U;
        static const AkUniqueID REGIONAMBIENCE = 3100698545U;
        static const AkUniqueID RIVERCLOSE = 155135507U;
        static const AkUniqueID RIVERFAR = 362167352U;
        static const AkUniqueID RUNNINGWIND_PLAY = 1918324573U;
        static const AkUniqueID RUNNINGWIND_STOP = 4104063435U;
        static const AkUniqueID TODAY = 1941965176U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace JUMP
        {
            static const AkUniqueID GROUP = 3833651337U;

            namespace STATE
            {
                static const AkUniqueID GROUNDED = 2907122923U;
                static const AkUniqueID INAIR = 1710892944U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace JUMP

        namespace MUSIC
        {
            static const AkUniqueID GROUP = 3991942870U;

            namespace STATE
            {
                static const AkUniqueID DAY = 311764537U;
                static const AkUniqueID ENDGAME = 4264815106U;
                static const AkUniqueID NIGHT = 1011622525U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace MUSIC

        namespace REGIONS
        {
            static const AkUniqueID GROUP = 2091077764U;

            namespace STATE
            {
                static const AkUniqueID FIELD = 514358619U;
                static const AkUniqueID FORREST = 760316600U;
                static const AkUniqueID MOUNTAINTOP = 946954817U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID OCEAN = 3802555985U;
            } // namespace STATE
        } // namespace REGIONS

    } // namespace STATES

    namespace SWITCHES
    {
        namespace JUMP
        {
            static const AkUniqueID GROUP = 3833651337U;

            namespace SWITCH
            {
                static const AkUniqueID GROUNDED = 2907122923U;
                static const AkUniqueID INAIR = 1710892944U;
            } // namespace SWITCH
        } // namespace JUMP

        namespace STEP
        {
            static const AkUniqueID GROUP = 621108255U;

            namespace SWITCH
            {
                static const AkUniqueID DIRT = 2195636714U;
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID LEAVES = 582824249U;
                static const AkUniqueID SNOW = 787898836U;
            } // namespace SWITCH
        } // namespace STEP

        namespace STEP_WATER
        {
            static const AkUniqueID GROUP = 901951531U;

            namespace SWITCH
            {
                static const AkUniqueID DRYLAND = 3451314871U;
                static const AkUniqueID WATER = 2654748154U;
            } // namespace SWITCH
        } // namespace STEP_WATER

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID TIMEOFDAY = 3729505769U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID GENERAL = 133642231U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMB = 1117531639U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID UI = 1551306167U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
