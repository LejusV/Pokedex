using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Karrablast Species to store common natural stats of all Karrablasts
	#region SpeciesKarrablast
	public class SpeciesKarrablast : PokemonSpecies
	{
#nullable enable
		private static SpeciesKarrablast? _instance = null;
#nullable restore
        public static SpeciesKarrablast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKarrablast();
                }
                return _instance;
            }
        }

		#region SpeciesKarrablast Constructor
		public SpeciesKarrablast() : base(
			588,
			"Karrablast",
			0.5,
			5.9,
			50, // HPs
			75, 45, // Attack & Defense
			40, 45, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Peck",
				"Counter",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Drill-Run",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Karrablast PokemonInstance Class
	#region Karrablast
	public class KarrablastInstance : PokemonInstance
	{
		#region Karrablast Constructors
		/// <summary>
		/// Karrablast Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KarrablastInstance(string nickname, int level)
		: base(
				SpeciesKarrablast.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Karrablast Builder only waiting for a Level
		/// </summary>
		public KarrablastInstance(int level)
		: base(
				SpeciesKarrablast.Instance, // PokemonInstance Species
				"Karrablast", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Karrablast Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KarrablastInstance() : base(
			SpeciesKarrablast.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}