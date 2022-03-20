using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Seismitoad Species to store common natural stats of all Seismitoads
	#region SeismitoadSpecies
	public class SeismitoadSpecies : PokemonSpecies
	{
#nullable enable
		private static SeismitoadSpecies? _instance = null;
#nullable restore
        public static SeismitoadSpecies Instance => _instance ?? (_instance = new SeismitoadSpecies());

		#region SeismitoadSpecies Constructor
		public SeismitoadSpecies() : base(
			537,
			"Seismitoad",
			Water.Instance, Ground.Instance,
			1.5,
			62.0,
			new PokemonStats(
				105, // HPs
				95, 75, // Attack & Defense
				85, 75, // Spacial Attack & Defense
				74 // Speed
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
				"Ice-Punch",
				"Growl",
				"Supersonic",
				"Acid",
				"Hydro-Pump",
				"Surf",
				"Bubble-Beam",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Pulse",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Aqua-Ring",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Stealth-Rock",
				"Grass-Knot",
				"Venoshock",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}