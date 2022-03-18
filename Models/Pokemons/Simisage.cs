using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Simisage Species to store common natural stats of all Simisages
	#region SpeciesSimisage
	public class SpeciesSimisage : PokemonSpecies
	{
#nullable enable
		private static SpeciesSimisage? _instance = null;
#nullable restore
        public static SpeciesSimisage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSimisage();
                }
                return _instance;
            }
        }

		#region SpeciesSimisage Constructor
		public SpeciesSimisage() : base(
			512,
			"Simisage",
			1.1,
			30.5,
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101		
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
				"Cut",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Covet",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Simisage PokemonInstance Class
	#region Simisage
	public class SimisageInstance : PokemonInstance
	{
		#region Simisage Constructors
		/// <summary>
		/// Simisage Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SimisageInstance(string nickname, int level)
		: base(
				SpeciesSimisage.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisage Builder only waiting for a Level
		/// </summary>
		public SimisageInstance(int level)
		: base(
				SpeciesSimisage.Instance, // PokemonInstance Species
				"Simisage", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisage Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SimisageInstance() : base(
			SpeciesSimisage.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}