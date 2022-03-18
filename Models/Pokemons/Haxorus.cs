using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Haxorus Species to store common natural stats of all Haxoruss
	#region SpeciesHaxorus
	public class SpeciesHaxorus : PokemonSpecies
	{
#nullable enable
		private static SpeciesHaxorus? _instance = null;
#nullable restore
        public static SpeciesHaxorus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHaxorus();
                }
                return _instance;
            }
        }

		#region SpeciesHaxorus Constructor
		public SpeciesHaxorus() : base(
			612,
			"Haxorus",
			1.8,
			105.5,
			76, // HPs
			147, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			97		
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
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Outrage",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Payback",
				"Assurance",
				"Fling",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Dual-Chop",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Haxorus PokemonInstance Class
	#region Haxorus
	public class HaxorusInstance : PokemonInstance
	{
		#region Haxorus Constructors
		/// <summary>
		/// Haxorus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HaxorusInstance(string nickname, int level)
		: base(
				SpeciesHaxorus.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haxorus Builder only waiting for a Level
		/// </summary>
		public HaxorusInstance(int level)
		: base(
				SpeciesHaxorus.Instance, // PokemonInstance Species
				"Haxorus", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haxorus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HaxorusInstance() : base(
			SpeciesHaxorus.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}