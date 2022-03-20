using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Porygon-Z Species to store common natural stats of all Porygon-Zs
	#region Porygon-ZSpecies
	public class PorygonZSpecies : PokemonSpecies
	{
#nullable enable
		private static PorygonZSpecies? _instance = null;
#nullable restore
        public static PorygonZSpecies Instance => _instance ?? (_instance = new PorygonZSpecies());

		#region Porygon-ZSpecies Constructor
		public PorygonZSpecies() : base(
			474,
			"Porygon-Z",
			Normal.Instance,
			0.9,
			34.0,
			new PokemonStats(
				85, // HPs
				80, 70, // Attack & Defense
				135, 75, // Spacial Attack & Defense
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
				"Tackle",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Agility",
				"Double-Team",
				"Recover",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Conversion",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Conversion-2",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Embargo",
				"Last-Resort",
				"Magnet-Rise",
				"Dark-Pulse",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Discharge",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Foul-Play",
				"Round",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}