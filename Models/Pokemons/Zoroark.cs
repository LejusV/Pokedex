using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zoroark Species to store common natural stats of all Zoroarks
	#region SpeciesZoroark
	public class SpeciesZoroark : PokemonSpecies
	{
#nullable enable
		private static SpeciesZoroark? _instance = null;
#nullable restore
        public static SpeciesZoroark Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZoroark();
                }
                return _instance;
            }
        }

		#region SpeciesZoroark Constructor
		public SpeciesZoroark() : base(
			571,
			"Zoroark",
			1.6,
			81.1,
			60, // HPs
			105, 60, // Attack & Defense
			120, 60, // Special Attack & Defense
			105		
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
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
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
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Punishment",
				"Dark-Pulse",
				"Night-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
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

	//Zoroark PokemonInstance Class
	#region Zoroark
	public class ZoroarkInstance : PokemonInstance
	{
		#region Zoroark Constructors
		/// <summary>
		/// Zoroark Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZoroarkInstance(string nickname, int level)
		: base(
				SpeciesZoroark.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zoroark Builder only waiting for a Level
		/// </summary>
		public ZoroarkInstance(int level)
		: base(
				SpeciesZoroark.Instance, // PokemonInstance Species
				"Zoroark", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zoroark Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZoroarkInstance() : base(
			SpeciesZoroark.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}