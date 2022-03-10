using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dartrix Species to store common natural stats of all Dartrixs
	#region SpeciesDartrix
	public class SpeciesDartrix : PokemonSpecies
	{
#nullable enable
		private static SpeciesDartrix? _instance = null;
#nullable restore
        public static SpeciesDartrix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDartrix();
                }
                return _instance;
            }
        }

		#region SpeciesDartrix Constructor
		public SpeciesDartrix() : base(
			"Dartrix",
			0.7,
			16.0,
			78, // HPs
			75, 75, // Attack & Defense
			70, 70, // Special Attack & Defense
			52		
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
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Peck",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Foresight",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Feather-Dance",
				"Astonish",
				"Leaf-Blade",
				"Roost",
				"Pluck",
				"Sucker-Punch",
				"Energy-Ball",
				"Brave-Bird",
				"Nasty-Plot",
				"Shadow-Claw",
				"Grass-Knot",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion

	//Dartrix PokemonInstance Class
	#region Dartrix
	public class DartrixInstance : PokemonInstance
	{
		#region Dartrix Constructors
		/// <summary>
		/// Dartrix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DartrixInstance(string nickname, int level)
		: base(
				723,
				SpeciesDartrix.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dartrix Builder only waiting for a Level
		/// </summary>
		public DartrixInstance(int level)
		: base(
				723,
				SpeciesDartrix.Instance, // PokemonInstance Species
				"Dartrix", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dartrix Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dartrix() : base(
			723,
			SpeciesDartrix.Instance, // PokemonInstance Species
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}