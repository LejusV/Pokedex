using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Weavile Species to store common natural stats of all Weaviles
	#region SpeciesWeavile
	public class SpeciesWeavile : PokemonSpecies
	{
#nullable enable
		private static SpeciesWeavile? _instance = null;
#nullable restore
        public static SpeciesWeavile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWeavile();
                }
                return _instance;
            }
        }

		#region SpeciesWeavile Constructor
		public SpeciesWeavile() : base(
			"Weavile",
			1.1,
			34.0,
			70, // HPs
			120, 65, // Attack & Defense
			45, 85, // Special Attack & Defense
			125		
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
				"Ice-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Leer",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Calm-Mind",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Avalanche",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Weavile PokemonInstance Class
	#region Weavile
	public class WeavileInstance : PokemonInstance
	{
		#region Weavile Constructors
		/// <summary>
		/// Weavile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WeavileInstance(string nickname, int level)
		: base(
				461,
				SpeciesWeavile.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weavile Builder only waiting for a Level
		/// </summary>
		public WeavileInstance(int level)
		: base(
				461,
				SpeciesWeavile.Instance, // PokemonInstance Species
				"Weavile", level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weavile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Weavile() : base(
			461,
			SpeciesWeavile.Instance, // PokemonInstance Species
			Dark.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}