using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Salamence Species to store common natural stats of all Salamences
	#region SpeciesSalamence
	public class SpeciesSalamence : PokemonSpecies
	{
#nullable enable
		private static SpeciesSalamence? _instance = null;
#nullable restore
        public static SpeciesSalamence Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSalamence();
                }
                return _instance;
            }
        }

		#region SpeciesSalamence Constructor
		public SpeciesSalamence() : base(
			373,
			"Salamence",
			1.5,
			102.6,
			95, // HPs
			135, 80, // Attack & Defense
			110, 80, // Special Attack & Defense
			100		
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
				"Fly",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Defog",
				"Draco-Meteor",
				"Stone-Edge",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Salamence PokemonInstance Class
	#region Salamence
	public class SalamenceInstance : PokemonInstance
	{
		#region Salamence Constructors
		/// <summary>
		/// Salamence Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SalamenceInstance(string nickname, int level)
		: base(
				SpeciesSalamence.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salamence Builder only waiting for a Level
		/// </summary>
		public SalamenceInstance(int level)
		: base(
				SpeciesSalamence.Instance, // PokemonInstance Species
				"Salamence", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salamence Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SalamenceInstance() : base(
			SpeciesSalamence.Instance, // PokemonInstance Species
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}