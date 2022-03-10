using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Genesect Species to store common natural stats of all Genesects
	#region SpeciesGenesect
	public class SpeciesGenesect : PokemonSpecies
	{
#nullable enable
		private static SpeciesGenesect? _instance = null;
#nullable restore
        public static SpeciesGenesect Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGenesect();
                }
                return _instance;
            }
        }

		#region SpeciesGenesect Constructor
		public SpeciesGenesect() : base(
			"Genesect",
			1.5,
			82.5,
			71, // HPs
			120, 95, // Attack & Defense
			120, 95, // Special Attack & Defense
			99		
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
				"Fly",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Flash",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Lock-On",
				"Giga-Drain",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Metal-Sound",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Gravity",
				"U-Turn",
				"Last-Resort",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Gunk-Shot",
				"Iron-Head",
				"Magnet-Bomb",
				"Bug-Bite",
				"Charge-Beam",
				"Hone-Claws",
				"Flame-Charge",
				"Simple-Beam",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Techno-Blast",
				"Fell-Stinger",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Genesect PokemonInstance Class
	#region Genesect
	public class GenesectInstance : PokemonInstance
	{
		#region Genesect Constructors
		/// <summary>
		/// Genesect Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GenesectInstance(string nickname, int level)
		: base(
				649,
				SpeciesGenesect.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Genesect Builder only waiting for a Level
		/// </summary>
		public GenesectInstance(int level)
		: base(
				649,
				SpeciesGenesect.Instance, // PokemonInstance Species
				"Genesect", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Genesect Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Genesect() : base(
			649,
			SpeciesGenesect.Instance, // PokemonInstance Species
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}