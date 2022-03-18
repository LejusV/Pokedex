using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Naganadel Species to store common natural stats of all Naganadels
	#region SpeciesNaganadel
	public class SpeciesNaganadel : PokemonSpecies
	{
#nullable enable
		private static SpeciesNaganadel? _instance = null;
#nullable restore
        public static SpeciesNaganadel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNaganadel();
                }
                return _instance;
            }
        }

		#region SpeciesNaganadel Constructor
		public SpeciesNaganadel() : base(
			804,
			"Naganadel",
			3.6,
			150.0,
			73, // HPs
			73, 73, // Attack & Defense
			127, 73, // Special Attack & Defense
			121		
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
				"Fly",
				"Fury-Attack",
				"Growl",
				"Acid",
				"Flamethrower",
				"Hyper-Beam",
				"Peck",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Sludge-Bomb",
				"Charm",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Helping-Hand",
				"Air-Cutter",
				"Aerial-Ace",
				"Dragon-Claw",
				"U-Turn",
				"Poison-Jab",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Shadow-Claw",
				"Draco-Meteor",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Acrobatics",
				"Dragon-Tail",
				"Snarl",
				"Fell-Stinger",
				"Confide",
				"Venom-Drench",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Naganadel PokemonInstance Class
	#region Naganadel
	public class NaganadelInstance : PokemonInstance
	{
		#region Naganadel Constructors
		/// <summary>
		/// Naganadel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NaganadelInstance(string nickname, int level)
		: base(
				SpeciesNaganadel.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Naganadel Builder only waiting for a Level
		/// </summary>
		public NaganadelInstance(int level)
		: base(
				SpeciesNaganadel.Instance, // PokemonInstance Species
				"Naganadel", level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Naganadel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NaganadelInstance() : base(
			SpeciesNaganadel.Instance, // PokemonInstance Species
			Poison.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}