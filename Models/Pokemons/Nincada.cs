using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nincada Species to store common natural stats of all Nincadas
	#region SpeciesNincada
	public class SpeciesNincada : PokemonSpecies
	{
#nullable enable
		private static SpeciesNincada? _instance = null;
#nullable restore
        public static SpeciesNincada Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNincada();
                }
                return _instance;
            }
        }

		#region SpeciesNincada Constructor
		public SpeciesNincada() : base(
			"Nincada",
			0.5,
			5.5,
			31, // HPs
			45, 90, // Attack & Defense
			30, 30, // Special Attack & Defense
			40		
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
				"Cut",
				"Gust",
				"Sand-Attack",
				"Double-Edge",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Bide",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Silver-Wind",
				"Aerial-Ace",
				"Natural-Gift",
				"Night-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Bug-Bite",
				"Hone-Claws",
				"Round",
				"Final-Gambit",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Nincada PokemonInstance Class
	#region Nincada
	public class NincadaInstance : PokemonInstance
	{
		#region Nincada Constructors
		/// <summary>
		/// Nincada Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NincadaInstance(string nickname, int level)
		: base(
				290,
				SpeciesNincada.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nincada Builder only waiting for a Level
		/// </summary>
		public NincadaInstance(int level)
		: base(
				290,
				SpeciesNincada.Instance, // PokemonInstance Species
				"Nincada", level,
				Bug.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nincada Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Nincada() : base(
			290,
			SpeciesNincada.Instance, // PokemonInstance Species
			Bug.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}