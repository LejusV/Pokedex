using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Giratina-Altered Species to store common natural stats of all Giratina-Altereds
	#region Giratina-AlteredSpecies
	public class GiratinaAlteredSpecies : PokemonSpecies
	{
#nullable enable
		private static GiratinaAlteredSpecies? _instance = null;
#nullable restore
        public static GiratinaAlteredSpecies Instance => _instance ?? (_instance = new GiratinaAlteredSpecies());

		#region Giratina-AlteredSpecies Constructor
		public GiratinaAlteredSpecies() : base(
			487,
			"Giratina-Altered",
			Ghost.Instance, Dragon.Instance,
			4.5,
			750.0,
			new PokemonStats(
				150, // HPs
				100, 120, // Attack & Defense
				100, 120, // Spacial Attack & Defense
				90 // Speed
			)			
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
}