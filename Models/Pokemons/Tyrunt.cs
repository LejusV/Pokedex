using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tyrunt Species to store common natural stats of all Tyrunts
	#region SpeciesTyrunt
	public class SpeciesTyrunt : PokemonSpecies
	{
#nullable enable
		private static SpeciesTyrunt? _instance = null;
#nullable restore
        public static SpeciesTyrunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTyrunt();
                }
                return _instance;
            }
        }

		#region SpeciesTyrunt Constructor
		public SpeciesTyrunt() : base(
			"Tyrunt",
			0.8,
			26.0,
			58, // HPs
			89, 77, // Attack & Defense
			45, 45, // Special Attack & Defense
			48		
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
				"Horn-Drill",
				"Tackle",
				"Thrash",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Outrage",
				"Sandstorm",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Poison-Fang",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Dragon-Dance",
				"Rock-Polish",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Earth-Power",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Tyrunt PokemonInstance Class
	#region Tyrunt
	public class TyruntInstance : PokemonInstance
	{
		#region Tyrunt Constructors
		/// <summary>
		/// Tyrunt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TyruntInstance(string nickname, int level)
		: base(
				696,
				SpeciesTyrunt.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrunt Builder only waiting for a Level
		/// </summary>
		public TyruntInstance(int level)
		: base(
				696,
				SpeciesTyrunt.Instance, // PokemonInstance Species
				"Tyrunt", level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrunt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Tyrunt() : base(
			696,
			SpeciesTyrunt.Instance, // PokemonInstance Species
			Rock.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}