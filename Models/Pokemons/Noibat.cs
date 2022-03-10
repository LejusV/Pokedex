using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Noibat Species to store common natural stats of all Noibats
	#region SpeciesNoibat
	public class SpeciesNoibat : PokemonSpecies
	{
#nullable enable
		private static SpeciesNoibat? _instance = null;
#nullable restore
        public static SpeciesNoibat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNoibat();
                }
                return _instance;
            }
        }

		#region SpeciesNoibat Constructor
		public SpeciesNoibat() : base(
			"Noibat",
			0.5,
			8.0,
			40, // HPs
			30, 35, // Attack & Defense
			45, 40, // Special Attack & Defense
			55		
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
				"Water-Pulse",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Dragon-Pulse",
				"Switcheroo",
				"Shadow-Claw",
				"Draco-Meteor",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Wild-Charge",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Noibat PokemonInstance Class
	#region Noibat
	public class NoibatInstance : PokemonInstance
	{
		#region Noibat Constructors
		/// <summary>
		/// Noibat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NoibatInstance(string nickname, int level)
		: base(
				714,
				SpeciesNoibat.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noibat Builder only waiting for a Level
		/// </summary>
		public NoibatInstance(int level)
		: base(
				714,
				SpeciesNoibat.Instance, // PokemonInstance Species
				"Noibat", level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noibat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Noibat() : base(
			714,
			SpeciesNoibat.Instance, // PokemonInstance Species
			Flying.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}