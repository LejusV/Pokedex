using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Delibird Species to store common natural stats of all Delibirds
	#region SpeciesDelibird
	public class SpeciesDelibird : PokemonSpecies
	{
#nullable enable
		private static SpeciesDelibird? _instance = null;
#nullable restore
        public static SpeciesDelibird Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDelibird();
                }
                return _instance;
            }
        }

		#region SpeciesDelibird Constructor
		public SpeciesDelibird() : base(
			225,
			"Delibird",
			0.9,
			16.0,
			45, // HPs
			55, 45, // Attack & Defense
			65, 45, // Special Attack & Defense
			75		
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
				"Fly",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Drill-Peck",
				"Counter",
				"Seismic-Toss",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Spikes",
				"Destiny-Bond",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Fake-Out",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Recycle",
				"Brick-Break",
				"Secret-Power",
				"Ice-Ball",
				"Signal-Beam",
				"Aerial-Ace",
				"Bounce",
				"Water-Pulse",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Seed-Bomb",
				"Avalanche",
				"Ice-Shard",
				"Defog",
				"Gunk-Shot",
				"Captivate",
				"Round",
				"Bestow",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Delibird PokemonInstance Class
	#region Delibird
	public class DelibirdInstance : PokemonInstance
	{
		#region Delibird Constructors
		/// <summary>
		/// Delibird Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DelibirdInstance(string nickname, int level)
		: base(
				SpeciesDelibird.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delibird Builder only waiting for a Level
		/// </summary>
		public DelibirdInstance(int level)
		: base(
				SpeciesDelibird.Instance, // PokemonInstance Species
				"Delibird", level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delibird Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DelibirdInstance() : base(
			SpeciesDelibird.Instance, // PokemonInstance Species
			Ice.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}