using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Giratina-Altered Species to store common natural stats of all Giratina-Altereds
	#region SpeciesGiratina-Altered
	public class SpeciesGiratinaAltered : PokemonSpecies
	{
#nullable enable
		private static SpeciesGiratinaAltered? _instance = null;
#nullable restore
        public static SpeciesGiratinaAltered Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGiratinaAltered();
                }
                return _instance;
            }
        }

		#region SpeciesGiratina-Altered Constructor
		public SpeciesGiratinaAltered() : base(
			487,
			"Giratina-Altered",
			4.5,
			750.0,
			150, // HPs
			100, 120, // Attack & Defense
			100, 120, // Special Attack & Defense
			90		
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
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Dragon-Claw",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Heal-Block",
				"Aura-Sphere",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Rock-Climb",
				"Defog",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Charge-Beam",
				"Ominous-Wind",
				"Shadow-Force",
				"Hone-Claws",
				"Telekinesis",
				"Round",
				"Echoed-Voice",
				"Hex",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Giratina-Altered PokemonInstance Class
	#region Giratina-Altered
	public class GiratinaAlteredInstance : PokemonInstance
	{
		#region Giratina-Altered Constructors
		/// <summary>
		/// Giratina-Altered Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GiratinaAlteredInstance(string nickname, int level)
		: base(
				SpeciesGiratinaAltered.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Giratina-Altered Builder only waiting for a Level
		/// </summary>
		public GiratinaAlteredInstance(int level)
		: base(
				SpeciesGiratinaAltered.Instance, // PokemonInstance Species
				"Giratina-Altered", level,
				Ghost.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Giratina-Altered Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GiratinaAlteredInstance() : base(
			SpeciesGiratinaAltered.Instance, // PokemonInstance Species
			Ghost.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}