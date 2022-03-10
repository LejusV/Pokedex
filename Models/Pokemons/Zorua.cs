using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zorua Species to store common natural stats of all Zoruas
	#region SpeciesZorua
	public class SpeciesZorua : PokemonSpecies
	{
#nullable enable
		private static SpeciesZorua? _instance = null;
#nullable restore
        public static SpeciesZorua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZorua();
                }
                return _instance;
            }
        }

		#region SpeciesZorua Constructor
		public SpeciesZorua() : base(
			"Zorua",
			0.7,
			12.5,
			40, // HPs
			65, 40, // Attack & Defense
			80, 40, // Special Attack & Defense
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Counter",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Detect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Extrasensory",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Copycat",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Nasty-Plot",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Night-Daze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Zorua PokemonInstance Class
	#region Zorua
	public class ZoruaInstance : PokemonInstance
	{
		#region Zorua Constructors
		/// <summary>
		/// Zorua Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZoruaInstance(string nickname, int level)
		: base(
				570,
				SpeciesZorua.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zorua Builder only waiting for a Level
		/// </summary>
		public ZoruaInstance(int level)
		: base(
				570,
				SpeciesZorua.Instance, // PokemonInstance Species
				"Zorua", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zorua Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Zorua() : base(
			570,
			SpeciesZorua.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}