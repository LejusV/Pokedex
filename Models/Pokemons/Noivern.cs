using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Noivern Species to store common natural stats of all Noiverns
	#region SpeciesNoivern
	public class SpeciesNoivern : PokemonSpecies
	{
#nullable enable
		private static SpeciesNoivern? _instance = null;
#nullable restore
        public static SpeciesNoivern Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNoivern();
                }
                return _instance;
            }
        }

		#region SpeciesNoivern Constructor
		public SpeciesNoivern() : base(
			715,
			"Noivern",
			1.5,
			85.0,
			85, // HPs
			70, 80, // Attack & Defense
			97, 80, // Special Attack & Defense
			123		
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
				"Razor-Wind",
				"Cut",
				"Gust",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Tackle",
				"Bite",
				"Supersonic",
				"Flamethrower",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Agility",
				"Screech",
				"Double-Team",
				"Dream-Eater",
				"Leech-Life",
				"Sky-Attack",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Aerial-Ace",
				"Dragon-Claw",
				"Water-Pulse",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Wild-Charge",
				"Hurricane",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Noivern PokemonInstance Class
	#region Noivern
	public class NoivernInstance : PokemonInstance
	{
		#region Noivern Constructors
		/// <summary>
		/// Noivern Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NoivernInstance(string nickname, int level)
		: base(
				SpeciesNoivern.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noivern Builder only waiting for a Level
		/// </summary>
		public NoivernInstance(int level)
		: base(
				SpeciesNoivern.Instance, // PokemonInstance Species
				"Noivern", level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noivern Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NoivernInstance() : base(
			SpeciesNoivern.Instance, // PokemonInstance Species
			Flying.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}