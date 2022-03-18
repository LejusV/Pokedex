using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Charmeleon Species to store common natural stats of all Charmeleons
	#region SpeciesCharmeleon
	public class SpeciesCharmeleon : PokemonSpecies
	{
#nullable enable
		private static SpeciesCharmeleon? _instance = null;
#nullable restore
        public static SpeciesCharmeleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCharmeleon();
                }
                return _instance;
            }
        }

		#region SpeciesCharmeleon Constructor
		public SpeciesCharmeleon() : base(
			5,
			"Charmeleon",
			1.1,
			19.0,
			58, // HPs
			64, 58, // Attack & Defense
			80, 65, // Special Attack & Defense
			80		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Growl",
				"Ember",
				"Flamethrower",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dragon-Rage",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Natural-Gift",
				"Fling",
				"Dragon-Pulse",
				"Shadow-Claw",
				"Fire-Fang",
				"Captivate",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Charmeleon PokemonInstance Class
	#region Charmeleon
	public class CharmeleonInstance : PokemonInstance
	{
		#region Charmeleon Constructors
		/// <summary>
		/// Charmeleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CharmeleonInstance(string nickname, int level)
		: base(
				SpeciesCharmeleon.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmeleon Builder only waiting for a Level
		/// </summary>
		public CharmeleonInstance(int level)
		: base(
				SpeciesCharmeleon.Instance, // PokemonInstance Species
				"Charmeleon", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmeleon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CharmeleonInstance() : base(
			SpeciesCharmeleon.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}