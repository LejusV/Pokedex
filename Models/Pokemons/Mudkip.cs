using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mudkip Species to store common natural stats of all Mudkips
	#region SpeciesMudkip
	public class SpeciesMudkip : PokemonSpecies
	{
#nullable enable
		private static SpeciesMudkip? _instance = null;
#nullable restore
        public static SpeciesMudkip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMudkip();
                }
                return _instance;
            }
        }

		#region SpeciesMudkip Constructor
		public SpeciesMudkip() : base(
			258,
			"Mudkip",
			0.4,
			7.6,
			50, // HPs
			70, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
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
				"Stomp",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Growl",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Strength",
				"Rock-Throw",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Barrier",
				"Bide",
				"Sludge",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
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
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Superpower",
				"Yawn",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Ice-Ball",
				"Rock-Tomb",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Earth-Power",
				"Avalanche",
				"Mud-Bomb",
				"Captivate",
				"Wide-Guard",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Mudkip PokemonInstance Class
	#region Mudkip
	public class MudkipInstance : PokemonInstance
	{
		#region Mudkip Constructors
		/// <summary>
		/// Mudkip Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MudkipInstance(string nickname, int level)
		: base(
				SpeciesMudkip.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudkip Builder only waiting for a Level
		/// </summary>
		public MudkipInstance(int level)
		: base(
				SpeciesMudkip.Instance, // PokemonInstance Species
				"Mudkip", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudkip Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MudkipInstance() : base(
			SpeciesMudkip.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}