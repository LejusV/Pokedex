using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mudsdale Species to store common natural stats of all Mudsdales
	#region SpeciesMudsdale
	public class SpeciesMudsdale : PokemonSpecies
	{
#nullable enable
		private static SpeciesMudsdale? _instance = null;
#nullable restore
        public static SpeciesMudsdale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMudsdale();
                }
                return _instance;
            }
        }

		#region SpeciesMudsdale Constructor
		public SpeciesMudsdale() : base(
			750,
			"Mudsdale",
			2.5,
			920.0,
			100, // HPs
			125, 100, // Attack & Defense
			55, 85, // Special Attack & Defense
			35		
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
				"Stomp",
				"Double-Kick",
				"Mega-Kick",
				"Roar",
				"Counter",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Superpower",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Payback",
				"Focus-Blast",
				"Giga-Impact",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Rototiller",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion

	//Mudsdale PokemonInstance Class
	#region Mudsdale
	public class MudsdaleInstance : PokemonInstance
	{
		#region Mudsdale Constructors
		/// <summary>
		/// Mudsdale Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MudsdaleInstance(string nickname, int level)
		: base(
				SpeciesMudsdale.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudsdale Builder only waiting for a Level
		/// </summary>
		public MudsdaleInstance(int level)
		: base(
				SpeciesMudsdale.Instance, // PokemonInstance Species
				"Mudsdale", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudsdale Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MudsdaleInstance() : base(
			SpeciesMudsdale.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}