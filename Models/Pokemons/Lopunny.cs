using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lopunny Species to store common natural stats of all Lopunnys
	#region SpeciesLopunny
	public class SpeciesLopunny : PokemonSpecies
	{
#nullable enable
		private static SpeciesLopunny? _instance = null;
#nullable restore
        public static SpeciesLopunny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLopunny();
                }
                return _instance;
            }
        }

		#region SpeciesLopunny Constructor
		public SpeciesLopunny() : base(
			"Lopunny",
			1.2,
			33.3,
			65, // HPs
			76, 84, // Attack & Defense
			54, 96, // Special Attack & Defense
			105		
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Jump-Kick",
				"Headbutt",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"High-Jump-Kick",
				"Dizzy-Punch",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Endure",
				"Charm",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Low-Sweep",
				"Entrainment",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Rototiller",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Lopunny PokemonInstance Class
	#region Lopunny
	public class LopunnyInstance : PokemonInstance
	{
		#region Lopunny Constructors
		/// <summary>
		/// Lopunny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LopunnyInstance(string nickname, int level)
		: base(
				428,
				SpeciesLopunny.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lopunny Builder only waiting for a Level
		/// </summary>
		public LopunnyInstance(int level)
		: base(
				428,
				SpeciesLopunny.Instance, // PokemonInstance Species
				"Lopunny", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lopunny Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lopunny() : base(
			428,
			SpeciesLopunny.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}