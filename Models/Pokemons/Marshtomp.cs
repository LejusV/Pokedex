using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Marshtomp Species to store common natural stats of all Marshtomps
	#region SpeciesMarshtomp
	public class SpeciesMarshtomp : PokemonSpecies
	{
#nullable enable
		private static SpeciesMarshtomp? _instance = null;
#nullable restore
        public static SpeciesMarshtomp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMarshtomp();
                }
                return _instance;
            }
        }

		#region SpeciesMarshtomp Constructor
		public SpeciesMarshtomp() : base(
			259,
			"Marshtomp",
			0.7,
			28.0,
			70, // HPs
			85, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			50		
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Stealth-Rock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Marshtomp PokemonInstance Class
	#region Marshtomp
	public class MarshtompInstance : PokemonInstance
	{
		#region Marshtomp Constructors
		/// <summary>
		/// Marshtomp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MarshtompInstance(string nickname, int level)
		: base(
				SpeciesMarshtomp.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshtomp Builder only waiting for a Level
		/// </summary>
		public MarshtompInstance(int level)
		: base(
				SpeciesMarshtomp.Instance, // PokemonInstance Species
				"Marshtomp", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshtomp Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MarshtompInstance() : base(
			SpeciesMarshtomp.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}