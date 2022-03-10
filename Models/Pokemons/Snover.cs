using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Snover Species to store common natural stats of all Snovers
	#region SpeciesSnover
	public class SpeciesSnover : PokemonSpecies
	{
#nullable enable
		private static SpeciesSnover? _instance = null;
#nullable restore
        public static SpeciesSnover Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSnover();
                }
                return _instance;
            }
        }

		#region SpeciesSnover Constructor
		public SpeciesSnover() : base(
			"Snover",
			1.0,
			50.5,
			60, // HPs
			62, 50, // Attack & Defense
			62, 60, // Special Attack & Defense
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
				"Ice-Punch",
				"Swords-Dance",
				"Stomp",
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Role-Play",
				"Ingrain",
				"Secret-Power",
				"Grass-Whistle",
				"Sheer-Cold",
				"Bullet-Seed",
				"Magical-Leaf",
				"Water-Pulse",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Snover PokemonInstance Class
	#region Snover
	public class SnoverInstance : PokemonInstance
	{
		#region Snover Constructors
		/// <summary>
		/// Snover Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SnoverInstance(string nickname, int level)
		: base(
				459,
				SpeciesSnover.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snover Builder only waiting for a Level
		/// </summary>
		public SnoverInstance(int level)
		: base(
				459,
				SpeciesSnover.Instance, // PokemonInstance Species
				"Snover", level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snover Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Snover() : base(
			459,
			SpeciesSnover.Instance, // PokemonInstance Species
			Grass.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}