using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Camerupt Species to store common natural stats of all Camerupts
	#region SpeciesCamerupt
	public class SpeciesCamerupt : PokemonSpecies
	{
#nullable enable
		private static SpeciesCamerupt? _instance = null;
#nullable restore
        public static SpeciesCamerupt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCamerupt();
                }
                return _instance;
            }
        }

		#region SpeciesCamerupt Constructor
		public SpeciesCamerupt() : base(
			"Camerupt",
			1.9,
			220.0,
			70, // HPs
			100, 70, // Attack & Defense
			105, 75, // Special Attack & Defense
			40		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Self-Destruct",
				"Fire-Blast",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Natural-Gift",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Camerupt PokemonInstance Class
	#region Camerupt
	public class CameruptInstance : PokemonInstance
	{
		#region Camerupt Constructors
		/// <summary>
		/// Camerupt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CameruptInstance(string nickname, int level)
		: base(
				323,
				SpeciesCamerupt.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Camerupt Builder only waiting for a Level
		/// </summary>
		public CameruptInstance(int level)
		: base(
				323,
				SpeciesCamerupt.Instance, // PokemonInstance Species
				"Camerupt", level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Camerupt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Camerupt() : base(
			323,
			SpeciesCamerupt.Instance, // PokemonInstance Species
			Fire.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}