using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hakamo-O Species to store common natural stats of all Hakamo-Os
	#region SpeciesHakamo-O
	public class SpeciesHakamoO : PokemonSpecies
	{
#nullable enable
		private static SpeciesHakamoO? _instance = null;
#nullable restore
        public static SpeciesHakamoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHakamoO();
                }
                return _instance;
            }
        }

		#region SpeciesHakamo-O Constructor
		public SpeciesHakamoO() : base(
			783,
			"Hakamo-O",
			1.2,
			47.0,
			55, // HPs
			75, 90, // Attack & Defense
			65, 70, // Special Attack & Defense
			65		
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
				"Headbutt",
				"Tackle",
				"Leer",
				"Roar",
				"Earthquake",
				"Toxic",
				"Screech",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Dragon-Dance",
				"Close-Combat",
				"Payback",
				"Fling",
				"X-Scissor",
				"Focus-Blast",
				"Shadow-Claw",
				"Draco-Meteor",
				"Autotomize",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Hakamo-O PokemonInstance Class
	#region Hakamo-O
	public class HakamoOInstance : PokemonInstance
	{
		#region Hakamo-O Constructors
		/// <summary>
		/// Hakamo-O Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HakamoOInstance(string nickname, int level)
		: base(
				SpeciesHakamoO.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hakamo-O Builder only waiting for a Level
		/// </summary>
		public HakamoOInstance(int level)
		: base(
				SpeciesHakamoO.Instance, // PokemonInstance Species
				"Hakamo-O", level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hakamo-O Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HakamoOInstance() : base(
			SpeciesHakamoO.Instance, // PokemonInstance Species
			Dragon.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}