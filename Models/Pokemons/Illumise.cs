using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Illumise Species to store common natural stats of all Illumises
	#region SpeciesIllumise
	public class SpeciesIllumise : PokemonSpecies
	{
#nullable enable
		private static SpeciesIllumise? _instance = null;
#nullable restore
        public static SpeciesIllumise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesIllumise();
                }
                return _instance;
            }
        }

		#region SpeciesIllumise Constructor
		public SpeciesIllumise() : base(
			314,
			"Illumise",
			0.6,
			17.7,
			65, // HPs
			47, 75, // Attack & Defense
			73, 85, // Special Attack & Defense
			85		
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
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Counter",
				"Seismic-Toss",
				"Growth",
				"Solar-Beam",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Metronome",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Sweet-Scent",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Wish",
				"Brick-Break",
				"Secret-Power",
				"Aromatherapy",
				"Fake-Tears",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Bug-Buzz",
				"Zen-Headbutt",
				"Captivate",
				"Bug-Bite",
				"Charge-Beam",
				"Ominous-Wind",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Play-Rough",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Illumise PokemonInstance Class
	#region Illumise
	public class IllumiseInstance : PokemonInstance
	{
		#region Illumise Constructors
		/// <summary>
		/// Illumise Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public IllumiseInstance(string nickname, int level)
		: base(
				SpeciesIllumise.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Illumise Builder only waiting for a Level
		/// </summary>
		public IllumiseInstance(int level)
		: base(
				SpeciesIllumise.Instance, // PokemonInstance Species
				"Illumise", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Illumise Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public IllumiseInstance() : base(
			SpeciesIllumise.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}