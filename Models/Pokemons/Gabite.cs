using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gabite Species to store common natural stats of all Gabites
	#region SpeciesGabite
	public class SpeciesGabite : PokemonSpecies
	{
#nullable enable
		private static SpeciesGabite? _instance = null;
#nullable restore
        public static SpeciesGabite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGabite();
                }
                return _instance;
            }
        }

		#region SpeciesGabite Constructor
		public SpeciesGabite() : base(
			444,
			"Gabite",
			1.4,
			56.0,
			68, // HPs
			90, 65, // Attack & Defense
			50, 55, // Special Attack & Defense
			82		
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
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Natural-Gift",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Shadow-Claw",
				"Rock-Climb",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dual-Chop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gabite PokemonInstance Class
	#region Gabite
	public class GabiteInstance : PokemonInstance
	{
		#region Gabite Constructors
		/// <summary>
		/// Gabite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GabiteInstance(string nickname, int level)
		: base(
				SpeciesGabite.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gabite Builder only waiting for a Level
		/// </summary>
		public GabiteInstance(int level)
		: base(
				SpeciesGabite.Instance, // PokemonInstance Species
				"Gabite", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gabite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GabiteInstance() : base(
			SpeciesGabite.Instance, // PokemonInstance Species
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}