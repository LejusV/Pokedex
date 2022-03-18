using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gible Species to store common natural stats of all Gibles
	#region SpeciesGible
	public class SpeciesGible : PokemonSpecies
	{
#nullable enable
		private static SpeciesGible? _instance = null;
#nullable restore
        public static SpeciesGible Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGible();
                }
                return _instance;
            }
        }

		#region SpeciesGible Constructor
		public SpeciesGible() : base(
			443,
			"Gible",
			0.7,
			20.5,
			58, // HPs
			70, 45, // Attack & Defense
			40, 45, // Special Attack & Defense
			42		
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
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
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
				"Scary-Face",
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
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
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
				"Mud-Shot",
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
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gible PokemonInstance Class
	#region Gible
	public class GibleInstance : PokemonInstance
	{
		#region Gible Constructors
		/// <summary>
		/// Gible Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GibleInstance(string nickname, int level)
		: base(
				SpeciesGible.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gible Builder only waiting for a Level
		/// </summary>
		public GibleInstance(int level)
		: base(
				SpeciesGible.Instance, // PokemonInstance Species
				"Gible", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gible Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GibleInstance() : base(
			SpeciesGible.Instance, // PokemonInstance Species
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}