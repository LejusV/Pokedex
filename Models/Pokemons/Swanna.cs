using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swanna Species to store common natural stats of all Swannas
	#region SpeciesSwanna
	public class SpeciesSwanna : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwanna? _instance = null;
#nullable restore
        public static SpeciesSwanna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwanna();
                }
                return _instance;
            }
        }

		#region SpeciesSwanna Constructor
		public SpeciesSwanna() : base(
			581,
			"Swanna",
			1.3,
			24.2,
			75, // HPs
			87, 63, // Attack & Defense
			87, 63, // Special Attack & Defense
			98		
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
				"Wing-Attack",
				"Fly",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Hail",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Feather-Dance",
				"Aerial-Ace",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Pluck",
				"Tailwind",
				"Aqua-Ring",
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Defog",
				"Round",
				"Scald",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Swanna PokemonInstance Class
	#region Swanna
	public class SwannaInstance : PokemonInstance
	{
		#region Swanna Constructors
		/// <summary>
		/// Swanna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwannaInstance(string nickname, int level)
		: base(
				SpeciesSwanna.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swanna Builder only waiting for a Level
		/// </summary>
		public SwannaInstance(int level)
		: base(
				SpeciesSwanna.Instance, // PokemonInstance Species
				"Swanna", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swanna Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwannaInstance() : base(
			SpeciesSwanna.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}