using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Reuniclus Specie to store common natural stats of every {'abilities': ['overcoat', 'magic-guard', 'regenerator'], 'base_experience': 221, 'height': 10, 'id': 579, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'hyper-beam', 'strength', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'recover', 'light-screen', 'reflect', 'dream-eater', 'dizzy-punch', 'flash', 'psywave', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'trick', 'role-play', 'superpower', 'magic-coat', 'knock-off', 'endeavor', 'skill-swap', 'snatch', 'secret-power', 'rock-tomb', 'signal-beam', 'iron-defense', 'calm-mind', 'shock-wave', 'gravity', 'gyro-ball', 'embargo', 'fling', 'heal-block', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'trick-room', 'grass-knot', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'confide', 'infestation', 'power-up-punch'], 'name': 'reuniclus', 'stats': {'hp': 110, 'attack': 65, 'defense': 75, 'special-attack': 125, 'special-defense': 85, 'speed': 30}, 'types': ['psychic'], 'weight': 201, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 50, 'color': 'green', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ランクルス', 'ko': '란쿨루스', 'zh-Hant': '人造細胞卵', 'fr': 'Symbios', 'de': 'Zytomega', 'es': 'Reuniclus', 'it': 'Reuniclus', 'en': 'Reuniclus', 'ja': 'ランクルス', 'zh-Hans': '人造细胞卵'}, 'genera': {'ja-Hrkt': 'ぞうふくポケモン', 'ko': '증폭포켓몬', 'zh-Hant': '增幅寶可夢', 'fr': 'Pokémon Multiplié', 'de': 'Vermehrung', 'es': 'Pokémon Ampliación', 'it': 'Pokémon Espansione', 'en': 'Multiplying Pokémon', 'ja': 'ぞうふくポケモン', 'zh-Hans': '增幅宝可梦'}}
	public class SpecieReuniclus : PokemonSpecie
	{
#nullable enable
		private static SpecieReuniclus? _instance = null;
#nullable restore
        public static SpecieReuniclus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieReuniclus();
                }
                return _instance;
            }
        }

		public SpecieReuniclus() : base(
			"Reuniclus",
			110, // HPs
			65, 75, // Attack & Defense
			125, 85, // Special Attack & Defense
			30			
		) {}
	}


	//Reuniclus Pokemon Class
	public class Reuniclus : Pokemon
	{

		public Reuniclus(string nickname, int level) : base(
			579,
			SpecieReuniclus.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Reuniclus() : base(
			579,
			SpecieReuniclus.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}