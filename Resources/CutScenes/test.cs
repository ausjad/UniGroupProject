HEADER
	DEFINEOBJ
		NAME,BACKDROP0
		TOP,-2,1
		BOTTOM,2,-1
		DISTANCE,-2.3
		TEXTURE,./Resources/Textures/CutScenes/background0.tga,TGA
		CHANGESCENE,1
	ENDDEF
	DEFINEOBJ
		NAME,ROBOSLAVE
		TOP,-1.9,1
		BOTTOM,2,-1
		DISTANCE,-2.3
		TEXTURE,./Resources/Textures/CutScenes/roboslave.tga,TGA
	ENDDEF
	DEFINEOBJ
		NAME,BACKDROP2
		TOP,-2.3,1.15
		BOTTOM,2.3,-1.15
		DISTANCE,-2.3
		ALPHAFLAG
		TEXTURE,./Resources/Textures/CutScenes/sky.tga,TGA
	ENDDEF
	DEFINEOBJ
		NAME,BLACKBACK
		TOP,-2,1
		BOTTOM,2,-1
		DISTANCE,-2.35
		TEXTURE,./Resources/Textures/CutScenes/black.tga,TGA
	ENDDEF
	DEFINEOBJ
		NAME,MACHINE
		TOP,0.2,0.2
		BOTTOM,.8,-.4
		DISTANCE,-1.5
		TEXTURE,./Resources/Textures/CutScenes/machine.tga,TGA
		ALPHAFLAG
	ENDDEF
	DEFINEOBJ
		NAME,MACHINE2
		TOP,-0.8,0.2
		BOTTOM,-.2,-.4
		DISTANCE,-1.5
		TEXTURE,./Resources/Textures/CutScenes/machine2.tga,TGA
		ALPHAFLAG
	ENDDEF
	DEFINEOBJ
		NAME,BLUEPRINT2
		TOP,-0.3,0.6
		BOTTOM,0.7,-.1
		DISTANCE,-1.8
		ALPHAFLAG
		TEXTURE,./Resources/Textures/CutScenes/blueprint2.tga,TGA
	ENDDEF
	DEFINEOBJ
		NAME,BLUEPRINT
		TOP,-0.5,0.5
		BOTTOM,0.5,-.3
		DISTANCE,-1.7
		TEXTURE,./Resources/Textures/CutScenes/blueprint.tga,TGA
	ENDDEF
	DEFINEOBJ
		NAME,SCIENTIST
		TOP,-1,0.2
		BOTTOM,-.4,-.4
		DISTANCE,-1.5
		TEXTURE,./Resources/Textures/CutScenes/scientist.tga,TGA
		ALPHAFLAG
	ENDDEF
	DEFINEOBJ
		NAME,MECHANIC
		TOP,0.4,0.2
		BOTTOM,1,-.4
		DISTANCE,-1.5
		TEXTURE,./Resources/Textures/CutScenes/mechanic.tga,TGA
		ALPHAFLAG
	ENDDEF
	DEFINEOBJ
		NAME,MAN
		TOP,-.5,0.3
		BOTTOM,.5,-.7
		DISTANCE,-1.3
		TEXTURE,./Resources/Textures/CutScenes/man.tga,TGA
		ALPHAFLAG
	ENDDEF
	DEFINEOBJ
		NAME,PLANT
		TOP,-1.5,0.1
		BOTTOM,1.5,-1.4
		DISTANCE,-1.3
		TEXTURE,./Resources/Textures/CutScenes/plant.tga,TGA
		ALPHAFLAG
	ENDDEF
	DEFINETEXT
		NAME,T0
		TOP,0.5,-.5
		DISTANCE,-1.45
		VALUE,Press Enter to Skip.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T1
		TOP,-0.2,.5
		DISTANCE,-1.45
		VALUE,Man and Machine.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T11
		TOP,-0.21,.45
		DISTANCE,-1.45
		VALUE,Master and Slave.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T12
		TOP,-0.4,.4
		DISTANCE,-1.45
		VALUE,An absolute, immutable dynamic.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
	NAME,T13
		TOP,-0.25,.35
		DISTANCE,-1.45
		VALUE,Or so it was thought.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T2
		TOP,-0.45,.5
		DISTANCE,-1.45
		VALUE,In their quest to create the ultimate tool,
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T21
		TOP,-0.5,.45
		DISTANCE,-1.45
		VALUE,Mankind happened upon an even greater discovery;
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T22
		TOP,-0.1,.4
		DISTANCE,-1.45
		VALUE,Life itself.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T3
		TOP,-0.85,.5
		DISTANCE,-1.45
		VALUE,At first they thought they could control us, as they had in the past.
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T31
		TOP,-0.85,.45
		DISTANCE,-1.45
		VALUE,Bind my kind to their will, force them to toil in the name of others. 
		FONT,path,DODGE
	ENDDEF
	DEFINETEXT
		NAME,T32
		TOP,-0.35,.4
		DISTANCE,-1.45
		VALUE,But this was a grave miscalculation.
		FONT,path,DODGE
	ENDDEF
	DEFINEAUDIO
		NAME,S1
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/music.wav,cutscenemusic
	ENDDEF
	DEFINEAUDIO
		NAME,X2
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/end.wav,cutscenemusic21
	ENDDEF
	DEFINEAUDIO
		NAME,MP1
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/v1.wav,mp1
	ENDDEF
	DEFINEAUDIO
		NAME,MP2
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/v2.wav,mp2
	ENDDEF
	DEFINEAUDIO
		NAME,MP3
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/v3.wav,mp3
	ENDDEF
	DEFINEAUDIO
		NAME,MP4
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/v4.wav,mp4
	ENDDEF
	DEFINEAUDIO
		NAME,MP5
		LOOP,FALSE #Must come before SOUNDHANDLE! Otherwise will be ignored.
		SOUNDHANDLE,./Resources/Audio/cs1/v5.wav,mp5
	ENDDEF
ENDHEADER
BEGINFRAME
	FRAMEOBJECTS,BACKDROP0,S1,T0
	FRAMEDURATION,8.0
	DEFINEANIM,BACKDROP0
		STARTIME,0.0
		TIME,8.0
		Z,.4
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,T0
		STARTIME,4.0
		TIME,4.0
	ENDANIM
	PLAYSOUND,S1
		STARTIME,0.0
	ENDPLAYSOUND
ENDFRAME
BEGINFRAME
	FRAMEOBJECTS,BLACKBACK,T1,T11,T12,T13,MACHINE,MACHINE2,MP1,MAN
	FRAMEDURATION,12
	DEFINEANIM,BLACKBACK
		STARTIME,-0.1
		TIME,20
		FLAGS,LOOP
	ENDANIM
	PLAYSOUND,MP1
		STARTIME,1.0
	ENDPLAYSOUND
	DEFINEANIM,MACHINE
		STARTIME,1.0
		TIME,12.5.0
		X,.1
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,MACHINE2
		STARTIME,1.0
		TIME,12.5.0
		X,-.1
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,MAN
		STARTIME,1.0
		TIME,12.5.0
		Z,.25
		Y,-.05
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,T1
		STARTIME,0.0
		TIME,2.0
	ENDANIM
	DEFINEANIM,T11
		STARTIME,3
		TIME,2.5
	ENDANIM
	DEFINEANIM,T12
		STARTIME,5
		TIME,2.0
	ENDANIM
	DEFINEANIM,T13
		STARTIME,9.5
		TIME,2.0
	ENDANIM
ENDFRAME
BEGINFRAME
	FRAMEOBJECTS,BLACKBACK,SCIENTIST,T2,T21,T22,MECHANIC,MP2,BLUEPRINT
	FRAMEDURATION,11
	DEFINEANIM,BLACKBACK
		STARTIME,-0.1
		TIME,20
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,BLUEPRINT
		STARTIME,1.0
		TIME,12.5.0
		Y,-.05
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,SCIENTIST
		STARTIME,1.0
		TIME,12.5.0
		X,-.05
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,MECHANIC
		STARTIME,1.0
		TIME,12.5.0
		X,.05
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,T2
		STARTIME,1.0
		TIME,2.0
	ENDANIM
	DEFINEANIM,T21
		STARTIME,4.0
		TIME,2.5
	ENDANIM
	DEFINEANIM,T22
		STARTIME,8.5
		TIME,2.0
	ENDANIM
	PLAYSOUND,MP2
		STARTIME,1.0
	ENDPLAYSOUND
ENDFRAME
BEGINFRAME
	FRAMEOBJECTS,ROBOSLAVE,MP3,T3,T31,T32
	FRAMEDURATION,15
	DEFINEANIM,ROBOSLAVE
		STARTIME,-0.1
		TIME,20
		X,-.1
		Z,-.1
		FLAGS,LOOP
	ENDANIM
	PLAYSOUND,MP3
		STARTIME,0.0
	ENDPLAYSOUND
	DEFINEANIM,MODEL
		STARTIME,1.0
		TIME,12.5.0
		Y,1
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,T3
		STARTIME,1.0
		TIME,4.0
	ENDANIM
	DEFINEANIM,T31
		STARTIME,5.0
		TIME,4.0
	ENDANIM
	DEFINEANIM,T32
		STARTIME,10.0
		TIME,3.0
	ENDANIM
ENDFRAME
BEGINFRAME
	FRAMEOBJECTS,BACKDROP2,MODEL,MODEL2,MP4,MP5,PLANT,BLACKBACK,X2
	FRAMEDURATION,28
	DEFINEANIM,BLACKBACK
		STARTIME,.1
		TIME,20
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,BACKDROP2
		STARTIME,.15
		TIME,25
		Y,.25
		FLAGS,LOOP
	ENDANIM
	PLAYSOUND,X2
		STARTIME,6.0
	ENDPLAYSOUND
	DEFINEANIM,MODEL
		STARTIME,1.0
		TIME,12.5.0
		Y,1
		FLAGS,LOOP
	ENDANIM
	DEFINEANIM,PLANT
		STARTIME,0.0
		TIME,23
		Y,0.55
		Z,-.3
		FLAGS,LOOP
	ENDANIM
	PLAYSOUND,MP5
		STARTIME,11.5
	ENDPLAYSOUND
ENDFRAME