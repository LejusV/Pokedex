using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Escavalier Species to store common natural stats of all Escavaliers
	#region SpeciesEscavalier
	public class SpeciesEscavalier : PokemonSpecies
	{
#nullable enable
		private static SpeciesEscavalier? _instance = null;
#nullable restore
        public static SpeciesEscavalier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEscavalier();
                }
                return _instance;
            }
        }

		#region SpeciesEscavalier Constructor
		public SpeciesEscavalier() : base(
			589,
			"Escavalier",
			1.0,
			33.0,
			70, // HPs
			135, 105, // Attack & Defense
			60, 105, // Special Attack & Defense
			20		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Double-Edge",
				"Twineedle",
				"Leer",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Buzz",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Iron-Head",
				"Bug-Bite",
				"Round",
				"Quick-Guard",
				"Struggle-Bug",
				"Drill-Run",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Escavalier PokemonInstance Class
	#region Escavalier
	public class EscavalierInstance : PokemonInstance
	{
		#region Escavalier Constructors
		/// <summary>
		/// Escavalier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EscavalierInstance(string nickname, int level)
		: base(
				SpeciesEscavalier.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Escavalier Builder only waiting for a Level
		/// </summary>
		public EscavalierInstance(int level)
		: base(
				SpeciesEscavalier.Instance, // PokemonInstance Species
				"Escavalier", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Escavalier Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EscavalierInstance() : base(
			SpeciesEscavalier.Instance, // PokemonInstance Species
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}