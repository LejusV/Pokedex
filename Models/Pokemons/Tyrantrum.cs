using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tyrantrum Species to store common natural stats of all Tyrantrums
	#region SpeciesTyrantrum
	public class SpeciesTyrantrum : PokemonSpecies
	{
#nullable enable
		private static SpeciesTyrantrum? _instance = null;
#nullable restore
        public static SpeciesTyrantrum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTyrantrum();
                }
                return _instance;
            }
        }

		#region SpeciesTyrantrum Constructor
		public SpeciesTyrantrum() : base(
			697,
			"Tyrantrum",
			2.5,
			270.0,
			82, // HPs
			121, 119, // Attack & Defense
			69, 59, // Special Attack & Defense
			71		
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
				"Hyper-Beam",
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
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Rock-Polish",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Head-Smash",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Tyrantrum PokemonInstance Class
	#region Tyrantrum
	public class TyrantrumInstance : PokemonInstance
	{
		#region Tyrantrum Constructors
		/// <summary>
		/// Tyrantrum Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TyrantrumInstance(string nickname, int level)
		: base(
				SpeciesTyrantrum.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrantrum Builder only waiting for a Level
		/// </summary>
		public TyrantrumInstance(int level)
		: base(
				SpeciesTyrantrum.Instance, // PokemonInstance Species
				"Tyrantrum", level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrantrum Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TyrantrumInstance() : base(
			SpeciesTyrantrum.Instance, // PokemonInstance Species
			Rock.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}