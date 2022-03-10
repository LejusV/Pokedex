using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kommo-O Species to store common natural stats of all Kommo-Os
	#region SpeciesKommo-O
	public class SpeciesKommoO : PokemonSpecies
	{
#nullable enable
		private static SpeciesKommoO? _instance = null;
#nullable restore
        public static SpeciesKommoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKommoO();
                }
                return _instance;
            }
        }

		#region SpeciesKommo-O Constructor
		public SpeciesKommoO() : base(
			"Kommo-O",
			1.6,
			78.2,
			75, // HPs
			110, 125, // Attack & Defense
			100, 105, // Special Attack & Defense
			85		
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
				"Flamethrower",
				"Hyper-Beam",
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
				"Belly-Drum",
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
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Draco-Meteor",
				"Autotomize",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Noble-Roar",
				"Confide",
				"Clanging-Scales",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Kommo-O PokemonInstance Class
	#region Kommo-O
	public class KommoOInstance : PokemonInstance
	{
		#region Kommo-O Constructors
		/// <summary>
		/// Kommo-O Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KommoOInstance(string nickname, int level)
		: base(
				784,
				SpeciesKommoO.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kommo-O Builder only waiting for a Level
		/// </summary>
		public KommoOInstance(int level)
		: base(
				784,
				SpeciesKommoO.Instance, // PokemonInstance Species
				"Kommo-O", level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kommo-O Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KommoO() : base(
			784,
			SpeciesKommoO.Instance, // PokemonInstance Species
			Dragon.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}