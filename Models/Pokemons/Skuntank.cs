using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skuntank Species to store common natural stats of all Skuntanks
	#region SpeciesSkuntank
	public class SpeciesSkuntank : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkuntank? _instance = null;
#nullable restore
        public static SpeciesSkuntank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkuntank();
                }
                return _instance;
            }
        }

		#region SpeciesSkuntank Constructor
		public SpeciesSkuntank() : base(
			"Skuntank",
			1.0,
			38.0,
			103, // HPs
			93, 67, // Attack & Defense
			71, 61, // Special Attack & Defense
			84		
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
				"Scratch",
				"Cut",
				"Headbutt",
				"Bite",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Fire-Blast",
				"Swift",
				"Poison-Gas",
				"Explosion",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Shadow-Claw",
				"Defog",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Acid-Spray",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Snarl",
				"Belch",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Skuntank PokemonInstance Class
	#region Skuntank
	public class SkuntankInstance : PokemonInstance
	{
		#region Skuntank Constructors
		/// <summary>
		/// Skuntank Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkuntankInstance(string nickname, int level)
		: base(
				435,
				SpeciesSkuntank.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skuntank Builder only waiting for a Level
		/// </summary>
		public SkuntankInstance(int level)
		: base(
				435,
				SpeciesSkuntank.Instance, // PokemonInstance Species
				"Skuntank", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skuntank Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Skuntank() : base(
			435,
			SpeciesSkuntank.Instance, // PokemonInstance Species
			Poison.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}