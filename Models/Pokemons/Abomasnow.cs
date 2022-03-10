using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Abomasnow Species to store common natural stats of all Abomasnows
	#region SpeciesAbomasnow
	public class SpeciesAbomasnow : PokemonSpecies
	{
#nullable enable
		private static SpeciesAbomasnow? _instance = null;
#nullable restore
        public static SpeciesAbomasnow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAbomasnow();
                }
                return _instance;
            }
        }

		#region SpeciesAbomasnow Constructor
		public SpeciesAbomasnow() : base(
			"Abomasnow",
			2.2,
			135.5,
			90, // HPs
			92, 75, // Attack & Defense
			92, 85, // Special Attack & Defense
			60		
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
				"Headbutt",
				"Leer",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
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
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Role-Play",
				"Ingrain",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Grass-Whistle",
				"Sheer-Cold",
				"Bullet-Seed",
				"Block",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Abomasnow PokemonInstance Class
	#region Abomasnow
	public class AbomasnowInstance : PokemonInstance
	{
		#region Abomasnow Constructors
		/// <summary>
		/// Abomasnow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AbomasnowInstance(string nickname, int level)
		: base(
				460,
				SpeciesAbomasnow.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abomasnow Builder only waiting for a Level
		/// </summary>
		public AbomasnowInstance(int level)
		: base(
				460,
				SpeciesAbomasnow.Instance, // PokemonInstance Species
				"Abomasnow", level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abomasnow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Abomasnow() : base(
			460,
			SpeciesAbomasnow.Instance, // PokemonInstance Species
			Grass.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}